using System;
using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;

using UWP.Core.Models;
using UWP.Core.Services;

namespace UWP.ViewModels
{
    public class ChartViewModel : ViewModelBase
    {
        public ChartViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
