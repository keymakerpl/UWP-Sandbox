using System;
using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;

using UWP.Core.Models;
using UWP.Core.Services;

namespace UWP.ViewModels
{
    public class TelerikDataGridViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
