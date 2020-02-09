using Prism.Mvvm;
using System;

namespace PrismWizard.Core
{
    public class WizardModel : BindableBase
    {
        private string _titleName;
        public string WiazrdName { get => _titleName; set => SetProperty(ref _titleName, value); }
    }
}
