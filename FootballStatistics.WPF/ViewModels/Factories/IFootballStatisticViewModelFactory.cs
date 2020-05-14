using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStatistics.WPF.ViewModels.Factories
{
    public interface IFootballStatisticViewModelFactory<T> where T:ViewModelBase
    {
        T CreateViewModel();
    }
}
