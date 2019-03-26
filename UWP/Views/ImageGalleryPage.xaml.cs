using System;

using UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWP.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ImageGalleryViewModel; }
        }

        public ImageGalleryPage()
        {
            InitializeComponent();
        }
    }
}
