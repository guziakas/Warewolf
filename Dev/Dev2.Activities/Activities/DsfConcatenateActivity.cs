using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unlimited.Applications.BusinessDesignStudio.Activities.Utilities;

namespace Dev2.Activities
{
    public class DsfConcatenateActivity : DsfBaseActivity
    {
        #region Overrides of DsfBaseActivity
        public DsfConcatenateActivity()
        {
            DisplayName = "Concatenate";
        }
        public override string DisplayName { get; set; }
        [Inputs("LeftString")]
        // ReSharper disable once UnusedMember.Global
        public string Left { get; set; }
        [Inputs("RightString")]
        // ReSharper disable once UnusedMember.Global
        public string Right { get; set; }
        protected override List<string> PerformExecution(Dictionary<string, string> evaluatedValues)
        {
            return new List<string> { Left + Right };
        }
           
        
        //protected override string PerformExecution(Dictionary<string, string> evaluatedValues)
        //{
        //    
        //}
        #endregion
    }
}
