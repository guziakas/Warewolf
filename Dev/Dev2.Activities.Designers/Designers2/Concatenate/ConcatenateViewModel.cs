using Dev2.Activities.Designers2.Core;
using Dev2.Interfaces;
using System;
using System.Activities.Presentation.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2.Activities.Designers2.Concatenate
{
    public class ConcatenateViewModel : ActivityDesignerViewModel, INotifyPropertyChanged
    {
        public ConcatenateViewModel(ModelItem modelItem)
            : base(modelItem)
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
        //[ExcludeFromCodeCoverage]
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
            var mainViewModel = CustomContainer.Get<IMainViewModel>();
            mainViewModel?.HelpViewModel.UpdateHelpText(helpText);
        }
    }
}
