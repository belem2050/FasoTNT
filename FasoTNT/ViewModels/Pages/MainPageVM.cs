using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using FasoTNT.ViewModels;
using Microsoft.Maui.Controls;

namespace FasoTNT.Views.Pages
{
    public partial class MainPageVM : ObservableObject
    {
        public SystemManager Manager { get; private set; } = SystemManager.GetInstance();

        public MainPageVM() 
        {
            createTVstations();
        }

        private void createTVstations()
        {
            Manager.TvStations.Add(new TvStation { Name = "Burkina Info",StreamUrl= "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",ImageUrl ="burkina_info.jpg", Description = "test" });
            Manager.TvStations.Add(new TvStation { Name = "Savane TV",StreamUrl= "https://live-hls-web-aje.getaj.net/AJE/01.m3u8", ImageUrl= "savane_tv.jpg,", Description = "test" });
            Manager.TvStations.Add(new TvStation { Name = "Rtb",StreamUrl= "https://live-hls-web-aje.getaj.net/AJE/01.m3u8", ImageUrl= "rtb.jpg", Description = "test" });
            Manager.TvStations.Add(new TvStation { Name = "Al jajeera",StreamUrl= "https://live-hls-web-aje.getaj.net/AJE/01.m3u8", ImageUrl= "al_jazeera.jpg,", Description = "test" });
        }
    }
}
