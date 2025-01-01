using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using FasoTNT.ViewModels;
using Microsoft.Maui.Controls;

namespace FasoTNT.Views.Pages
{
    public partial class MainPageVM : ObservableObject
    {
        public SystemManager Manager { get; private set; } = SystemManager.GetInstance();

        private CarouselView _carouselView = new CarouselView();

        private MediaElement _videoPlayer = new MediaElement();

       

        public MainPageVM(CarouselView carroselview ) 
        {
            _carouselView = carroselview;

            _carouselView.CurrentItemChanged += CarroselView_CurrentItemChanged;
            createTVstations();
        }

        private void CarroselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            if (e.PreviousItem is TvStation previousStation && previousStation.VideoPlayer != null)
            {
                // Pause the previous station's media
                previousStation.VideoPlayer.Pause();
            }

            if (e.CurrentItem is TvStation currentStation && currentStation.VideoPlayer != null)
            {
                // Play the current station's media
                currentStation.VideoPlayer.Play();
            }
        }


        private void createTVstations()
        {
            //Manager.TvStations.Add(new TvStation { Name = "RTB", Description = "test" });
            Manager.TvStations.Add(new TvStation { Name = "Burkina Info",StreamUrl= "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",ImageUrl ="hdfhjfd", Description = "test" });
            Manager.TvStations.Add(new TvStation { Name = "Al jajeera",StreamUrl= "https://live-hls-web-aje.getaj.net/AJE/01.m3u8", ImageUrl= "hbghbn,", Description = "test" });
        }
    }
}
