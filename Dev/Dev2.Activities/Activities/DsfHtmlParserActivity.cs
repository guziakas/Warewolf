

using System;
using System.Activities;
using System.Activities.Presentation.Model;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Dev2.Activities.Debug;
using Dev2.Common.Interfaces.Diagnostics.Debug;
using Dev2.Common.Interfaces.Toolbox;
using Dev2.Data;
using Dev2.Data.Parsers;
using Dev2.Data.Util;
using Dev2.DataList.Contract;
using Dev2.Diagnostics;
using Dev2.Interfaces;
using Unlimited.Applications.BusinessDesignStudio.Activities;
using Warewolf.Core;
using Warewolf.Storage;


namespace Dev2.Activities
{
    [ToolDescriptorInfo("Html parser", "Html", ToolType.Native, "F578E19B-A877-4216-B70B-E951D5964D57", "Dev2.Acitivities", "1.0.0.0", "Legacy", "Utility", "/Warewolf.Studio.Themes.Luna;component/Images.xaml", "Tool_Utility_Xpath_Tags")]

    public class DsfHtmlParserActivity : DsfActivityAbstract<string>, ICollectionActivity
    {
        public void AddListToCollection(IList<string> listToAdd, bool overwrite, ModelItem modelItem)
        {
            //throw new NotImplementedException();
        }

        public int GetCollectionCount()
        {

            //throw new NotImplementedException();
            return 0; 
        }

        public override IList<DsfForEachItem> GetForEachInputs()
        {
            //throw new NotImplementedException();
            return new List<DsfForEachItem>();
        }

        public override IList<DsfForEachItem> GetForEachOutputs()
        {
            //throw new NotImplementedException();
            return new List<DsfForEachItem>();
        }

        public override void UpdateForEachInputs(IList<Tuple<string, string>> updates)
        {
        //    throw new NotImplementedException();
        }

        public override void UpdateForEachOutputs(IList<Tuple<string, string>> updates)
        {
           // throw new NotImplementedException();
        }

        protected override void ExecuteTool(IDSFDataObject dataObject, int update)
        {
          //  throw new NotImplementedException();
        }

        protected override void OnExecute(NativeActivityContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
