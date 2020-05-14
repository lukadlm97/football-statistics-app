using FootballStatistics.WPF.Commands;
using FootballStatistics.WPF.Models;
using FootballStatistics.WPF.ViewModels;
using FootballStatistics.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FootballStatistics.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand { get; set; }
        public Navigator(IRootFootballStatisticViewModelFactory viewModelFactory)
        {
            UpdateCurrentViewModelCommand = new UpdateCurentViewModelCommand(this,viewModelFactory);
        }
    }
}
