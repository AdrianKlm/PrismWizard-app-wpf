using Prism.Regions;
using PrismWizard.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismWizard.Application.ViewModels
{
    public class Step_1_ViewModel : BaseViewModel, INavigationAware
    {
        private WizardModel _model;

        public WizardModel Model { get => _model; set => SetProperty(ref _model, value); }

        public Step_1_ViewModel()
        {
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
            //true - tworzy obiekt viewmodelu raz
            //false-  tworzy obiekt viewmodelu za kazdym razem przy nawigacji
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            if(navigationContext.Parameters.TryGetValue<WizardModel>("Model", out WizardModel a))
            {
                this.Model = a;
            }
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
          //Na wejsciu do widoku  
        }
    }
}
