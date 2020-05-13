using FootballStatistics.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.WPF.ViewModels.Factories
{
    public interface IRootFootballStatisticViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
