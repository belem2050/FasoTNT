using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FasoTNT.ViewModels.Pages
{
    public partial class PlayerPageVM : ObservableObject
    {

        public  TvStation CurrentTvStation { get; set; } = SystemManager.GetInstance().CurrentTvStation;

        public PlayerPageVM()
        {
        }
    }
}
