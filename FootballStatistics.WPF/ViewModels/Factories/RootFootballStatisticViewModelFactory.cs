using FootballStatistics.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.WPF.ViewModels.Factories
{
    public class RootFootballStatisticViewModelFactory : IRootFootballStatisticViewModelFactory
    {
        private readonly IFootballStatisticViewModelFactory<LoginViewModel> _loginViewModelFactory;

        public RootFootballStatisticViewModelFactory(IFootballStatisticViewModelFactory<LoginViewModel> loginViewModel)
        {
            _loginViewModelFactory = loginViewModel;
        }


        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _loginViewModelFactory.CreateViewModel();
                default:
                    throw new ArgumentException("The ViewType dose not have a ViewModel.");
            }
        }
    }
}
