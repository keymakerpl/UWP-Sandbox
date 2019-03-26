using System;

using UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWP.Views
{
    public sealed partial class ContentGridPage : Page
    {
        private ContentGridViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ContentGridViewModel; }
        }

        public ContentGridPage()
        {
            InitializeComponent();
        }
    }
}
