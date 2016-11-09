using Dev2.Activities.Designers2.Core;
using System;
using System.Activities.Presentation.Model;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2.Activities.Designers2.HtmlParser
{
    public class HtmlParserViewModel: ActivityDesignerViewModel, INotifyPropertyChanged
    {
        public HtmlParserViewModel(ModelItem modelItem) : base(modelItem)
        {

        }
        public string Left
        {
            get { return GetProperty<string>(); }
            set
            {
                SetProperty(value);
                OnPropertyChanged("Operation");
            }
        }
        public string Right
        {
            get { return GetProperty<string>(); }
            set
            {
                SetProperty(value);
                OnPropertyChanged("Operation");
            }
        }
        public override void Validate()
        {
        }
        public event PropertyChangedEventHandler PropertyChanged;
       
        protected void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override void UpdateHelpDescriptor(string helpText)
        {
            //throw new NotImplementedException();
        }
    }
}
