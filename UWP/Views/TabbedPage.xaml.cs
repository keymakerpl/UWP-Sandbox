using System;

using UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWP.Views
{
    public sealed partial class TabbedPage : Page
    {
        private TabbedViewModel ViewModel
        {
            get { return ViewModelLocator.Current.TabbedViewModel; }
        }

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
