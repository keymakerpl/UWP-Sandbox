using System;

using UWP.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UWP.Views
{
    public sealed partial class CustomerView : Page
    {
        private CustomerViewModel ViewModel
        {
            get { return ViewModelLocator.Current.CustomerViewModel; }
        }

        public CustomerView()
        {
            InitializeComponent();
            Loaded += CustomerView_Loaded;
        }

        private async void CustomerView_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(CustomerViewControl.ViewState);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            // Workaround for issue on MasterDetail Control. Find More info at https://github.com/Microsoft/WindowsTemplateStudio/issues/2738
            ViewModel.Selected = null;
        }
    }
}
