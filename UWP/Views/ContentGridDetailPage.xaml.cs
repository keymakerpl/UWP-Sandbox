using System;

using Microsoft.Toolkit.Uwp.UI.Animations;

using UWP.Services;
using UWP.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UWP.Views
{
    public sealed partial class ContentGridDetailPage : Page
    {
        private ContentGridDetailViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ContentGridDetailViewModel; }
        }

        public NavigationServiceEx NavigationService => ViewModelLocator.Current.NavigationService;

        public ContentGridDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is long orderId)
            {
                ViewModel.Initialize(orderId);
            }
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                NavigationService.Frame.SetListDataItemForNextConnectedAnnimation(ViewModel.Item);
            }
        }
    }
}
