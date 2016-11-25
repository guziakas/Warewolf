/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2016 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Activities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Dev2.Common;
using Dev2.Common.Interfaces.Diagnostics.Debug;
using Dev2.Data;
using Dev2.Data.Util;
using Dev2.DataList.Contract;
using Dev2.Diagnostics;
using Dev2.Interfaces;
using Dev2.Util;
using Unlimited.Applications.BusinessDesignStudio.Activities;
using Unlimited.Applications.BusinessDesignStudio.Activities.Utilities;
using Warewolf.Storage;
using Warewolf.Core;
using Dev2.Common.Interfaces.Toolbox;
using WarewolfParserInterop;
using System.Net;
using System.Text;
using System.Collections.Specialized;

namespace Dev2.Activities
{
    [ToolDescriptorInfo("Utility-GetWebRequest", "Web Client (CUSTOM)", ToolType.Native, "0CBE331F-1B15-4B93-ACA2-204862EB4C51", "Dev2.Acitivities", "1.0.0.0", "Legacy", "Utility", "/Warewolf.Studio.Themes.Luna;component/Images.xaml", "Tool_WebMethod_Get_Tags")]    
    public class DsfWebClientActivity : DsfActivityAbstract<string>
    {

        //private readonly CookieContainer cookieContainer = new CookieContainer();

        private List<String> CookieCollection { get; set; } = new List<string>();

        #region Properties
        IWebRequestInvoker _webRequestInvoker;
        public IWebRequestInvoker WebRequestInvoker
        {
            get
            {
                return _webRequestInvoker ?? (_webRequestInvoker = new WebRequestInvoker());
            }
            set
            {
                _webRequestInvoker = value;
            }
        }

        [Inputs("Method")]
        [FindMissing]        
        public string Method { get; set; }

        [Inputs("Url")]
        [FindMissing]
        public string Url { get; set; }

        [FindMissing]
        public string Headers { get; set; }

        [Inputs("PostData")]
        [FindMissing]
        public string PostData { get; set; }

        /// <summary>
        /// The property that holds the result string the user enters into the "Result" box
        /// </summary>
        [Outputs("Result")]
        [FindMissing]
        public new string Result { get; set; }

        [FindMissing]
        [Outputs("Cookies")]
        [Inputs("Cookies")]
        public string Cookies { get; set; }

        #endregion

        public DsfWebClientActivity() : base("Web Client (Custom)")
        {
            //Method = "GET";
            Headers = string.Empty;
        }

        /// <summary>
        ///     When overridden runs the activity's execution logic
        /// </summary>
        /// <param name="context">The context to be used.</param>
        protected override void OnExecute(NativeActivityContext context)
        {
            var dataObject = context.GetExtension<IDSFDataObject>();
            ExecuteTool(dataObject, 0);
        }

        protected override void ExecuteTool(IDSFDataObject dataObject, int update)
        {
            _debugOutputs.Clear();
            _debugInputs.Clear();
            if (WebRequestInvoker == null)
            {
                return;
            }

            var allErrors = new ErrorResultTO();
            InitializeDebug(dataObject);
            try
            {
                allErrors.MergeErrors(errorsTo);
                if (dataObject.IsDebugMode())
                {
                    DebugItem debugItem = new DebugItem();
                    AddDebugItem(new DebugEvalResult(Url, "URL", dataObject.Environment, update), debugItem);
                    _debugInputs.Add(debugItem);
                }
                var colItr = new WarewolfListIterator();
                var urlitr = new WarewolfIterator(dataObject.Environment.Eval(Url, update));
                var headerItr = new WarewolfIterator(dataObject.Environment.Eval(Headers, update));
              
                colItr.AddVariableToIterateOn(urlitr);
                colItr.AddVariableToIterateOn(headerItr);
               
                const int IndexToUpsertTo = 1;
                while (colItr.HasMoreData())
                {
                    var c = colItr.FetchNextValue(urlitr);
                    var headerValue = colItr.FetchNextValue(headerItr);
                    

                    var headers = string.IsNullOrEmpty(headerValue) ? new string[0] : headerValue.Split(new[] { '\n', '\r', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    var headersEntries = new List<Tuple<string, string>>();

                    foreach (var header in headers)
                    {
                        var headerSegments = header.Split(':');
                        headersEntries.Add(new Tuple<string, string>(headerSegments[0], headerSegments[1]));

                        if (dataObject.IsDebugMode())
                        {
                            DebugItem debugItem = new DebugItem();
                            AddDebugItem(new DebugEvalResult(Headers, "Header", dataObject.Environment, update), debugItem);
                            _debugInputs.Add(debugItem);
                        }
                    }
                    string postData = null;
                    if (PostData != null)
                    {
                        postData = ExecutionEnvironment.WarewolfEvalResultToString(dataObject.Environment.Eval(PostData, update));
                    }
                    if (dataObject.IsDebugMode() && PostData != null)
                    {
                        DebugItem debugItem = new DebugItem();
                        AddDebugItem(new DebugEvalResult(postData, "PostData", dataObject.Environment, update), debugItem);
                        _debugInputs.Add(debugItem);
                    }

                    //act
                    var result = ExecuteRequest(Method, c,postData, headersEntries);

                    allErrors.MergeErrors(errorsTo);
                    var expression = GetExpression(IndexToUpsertTo);

                   
                    if (dataObject.IsDebugMode())
                    {
                        var cookieValue = ExecutionEnvironment.WarewolfEvalResultToString(dataObject.Environment.Eval(Cookies, update));
                        DebugItem debugItem = new DebugItem();
                        AddDebugItem(new DebugEvalResult(cookieValue, "Cookies", dataObject.Environment, update), debugItem);
                        _debugInputs.Add(debugItem);
                    }

                    PushResultsToDataList(expression, result, dataObject, update);
                    //PushResultsToDataList(Test, CookieCollection.Aggregate((current, next) => current + ", " + next), dataObject, update);
                    var cookieString = CookieCollection.Aggregate((current, next) => current + ";" + next);
                    dataObject.Environment.AssignWithFrame(new AssignValue(Cookies,cookieString), update);

                    if (dataObject.IsDebugMode())
                    {
                        DebugItem debugItem = new DebugItem();
                        AddDebugItem(new DebugEvalResult(cookieString, "Cookies", dataObject.Environment, update), debugItem);
                        _debugInputs.Add(debugItem);
                    }
                }
                

            }
            catch (Exception e)
            {
                Dev2Logger.Error("DSFWebGetRequest", e);
                allErrors.AddError(e.Message);
            }
            finally
            {
                if (allErrors.HasErrors())
                {
                    DisplayAndWriteError("DsfWebGetRequestActivity", allErrors);
                    var errorString = allErrors.MakeDisplayReady();
                    dataObject.Environment.AddError(errorString);
                    var expression = GetExpression(1);
                    PushResultsToDataList(expression, null, dataObject, update);
                }
                if (dataObject.IsDebugMode())
                {
                    DispatchDebugState(dataObject, StateType.Before, update);
                    DispatchDebugState(dataObject, StateType.After, update);
                }
            }
        }


        #region Overrides of DsfNativeActivity<string>


        string GetExpression(int indexToUpsertTo)
        {
            string expression;
            if(DataListUtil.IsValueRecordset(Result) && DataListUtil.GetRecordsetIndexType(Result) == enRecordsetIndexType.Star)
            {
                expression = Result.Replace(GlobalConstants.StarExpression, indexToUpsertTo.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                expression = Result;
            }
            return expression;
        }

        void PushResultsToDataList(string expression,  string result, IDSFDataObject dataObject,int update)
        {
            UpdateResultRegions(expression, dataObject.Environment, result, update);
            if(dataObject.IsDebugMode())
            {
                
                    AddDebugOutputItem(new DebugEvalResult(expression,"",dataObject.Environment, update));
            }
        }

        void UpdateResultRegions(string expression, IExecutionEnvironment environment, string result, int update)
        {
            foreach(var region in DataListCleaningUtils.SplitIntoRegions(expression))
            {
                environment.Assign(region, result, update);
            }
        }

        #region Get Debug Inputs/Outputs

        #region GetDebugInputs

        public override List<DebugItem> GetDebugInputs(IExecutionEnvironment dataList, int update)
        {
            foreach(IDebugItem debugInput in _debugInputs)
            {
                debugInput.FlushStringBuilder();
            }
            return _debugInputs;
        }

        #endregion

        #region GetDebugOutputs

        public override List<DebugItem> GetDebugOutputs(IExecutionEnvironment dataList, int update)
        {
            foreach(IDebugItem debugOutput in _debugOutputs)
            {
                debugOutput.FlushStringBuilder();
            }
            return _debugOutputs;
        }

        #endregion

        #endregion

        public override void UpdateForEachInputs(IList<Tuple<string, string>> updates)
        {
            if(updates != null)
            {
                foreach(Tuple<string, string> t in updates)
                {

                    if(t.Item1 == Url)
                    {
                        Url = t.Item2;
                    }
                }
            }
        }

        public override void UpdateForEachOutputs(IList<Tuple<string, string>> updates)
        {
            if(updates != null)
            {
                var itemUpdate = updates.FirstOrDefault(tuple => tuple.Item1 == Result);
                if(itemUpdate != null)
                {
                    Result = itemUpdate.Item2;
                }
            }
        }

        #region GetForEachInputs/Outputs

        public override IList<DsfForEachItem> GetForEachInputs()
        {
            return GetForEachItems(Url);
        }

        public override IList<DsfForEachItem> GetForEachOutputs()
        {
            return GetForEachItems(Result);
        }

        #endregion
        #endregion

        public string ExecuteRequest(string method, string url, string data, List<Tuple<string, string>> headers = null, Action<string> asyncCallback = null)
        {
            using (var webClient = new WebClient())
            {
                webClient.Credentials = CredentialCache.DefaultCredentials;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36");
                webClient.Encoding = Encoding.UTF8;
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        webClient.Headers.Add(header.Item1, header.Item2);
                    }
                }

                var uri = new Uri(url.Contains("http://") || url.Contains("https://") ? url : "http://" + url);

                switch (method)
                {
                    case "GET":
                        if (asyncCallback == null)
                        {
                            
                            var result = webClient.DownloadString(uri);
                            var nameValueCollection = (NameValueCollection)webClient.ResponseHeaders;

                            var kukiai = webClient.ResponseHeaders.GetValues("set-cookie");
                            CookieCollection.AddRange(kukiai);
                             
                            return result;
                        }

                        webClient.DownloadStringCompleted += (sender, args) => asyncCallback(args.Result);
                        webClient.DownloadStringAsync(uri, null);

                        break;
                    case "POST":
                        if (asyncCallback == null)
                        {
                            var result = webClient.UploadString(uri, data);
                            var kukiai = webClient.ResponseHeaders.GetValues("set-cookie");
                            CookieCollection.AddRange(kukiai);

                            return result;
                        }

                        webClient.UploadStringCompleted += (sender, args) => asyncCallback(args.Result);
                        webClient.UploadStringAsync(uri, data);

                        break;
                }
            }
            return string.Empty;
        }
    }
}
