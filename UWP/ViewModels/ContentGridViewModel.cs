using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using Microsoft.Toolkit.Uwp.UI.Animations;

using UWP.Core.Models;
using UWP.Core.Services;
using UWP.Services;

namespace UWP.ViewModels
{
    public class ContentGridViewModel : ViewModelBase
    {
        public NavigationServiceEx NavigationService => ViewModelLocator.Current.NavigationService;

        private ICommand _itemClickCommand;

        public ICommand ItemClickCommand => _itemClickCommand ?? (_itemClickCommand = new RelayCommand<SampleOrder>(OnItemClick));

        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetContentGridData();
            }
        }

        public ContentGridViewModel()
        {
        }

        private void OnItemClick(SampleOrder clickedItem)
        {
            if (clickedItem != null)
            {
                NavigationService.Frame.SetListDataItemForNextConnectedAnnimation(clickedItem);
                NavigationService.Navigate(typeof(ContentGridDetailViewModel).FullName, clickedItem.OrderId);
            }
        }
    }
}
