using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FasoTNT.ViewModels
{

    public partial class TvStation : ObservableObject
    {

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string description = string.Empty;

        [ObservableProperty]
        private string imageUrl = string.Empty;

        [ObservableProperty]
        private string streamUrl = string.Empty;

        [ObservableProperty]
        private MediaElement videoPlayer = new MediaElement();

        public TvStation() 
        {
        }
    }
}
