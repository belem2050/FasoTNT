using CommunityToolkit.Maui.Views;
using FasoTNT.ViewModels;
using FasoTNT.Views.Pages;

namespace FasoTNT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM(carroselView);
        }

        private void VideoPlayer_BindingContextChanged(object sender, EventArgs e)
        {
            if (sender is MediaElement mediaElement && mediaElement.BindingContext is TvStation tvStation)
            {
                tvStation.VideoPlayer = mediaElement;
            }
        }


    }
}
