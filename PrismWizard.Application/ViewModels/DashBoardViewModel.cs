using Prism.Commands;
using Prism.Regions;
using PrismWizard.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PrismWizard.Application.ViewModels
{
    public class DashBoardViewModel : BaseViewModel
    {
        public WizardModel Model { get => _model; set => SetProperty(ref _model, value); }
        public ICommand StartCommand { get; private set; }

        public DashBoardViewModel(IRegionManager regionManager)
        {
            StartCommand = new DelegateCommand(StartAction);
            this.regionManager = regionManager;
        }

        private void StartAction()
        {
            NavigationParameters param = new NavigationParameters
            {
                { "Model", _model }
            };
            regionManager.RequestNavigate(RegionName.ContentRegion, ViewHelper.GetViewName(typeof(Step_1_ViewModel)), param);
        }

        private WizardModel _model = new WizardModel() { WiazrdName="Kreator sprawdzenia"};
        private readonly IRegionManager regionManager;
    }
}
