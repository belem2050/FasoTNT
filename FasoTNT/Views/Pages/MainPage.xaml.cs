using FasoTNT.ViewModels;
namespace FasoTNT.Views.Pages;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;


public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageVM();
    }


    private async void OnChannelImageButton_Clicked(object? sender, EventArgs e)
    {
        SystemManager.GetInstance().CurrentTvStation = (TvStation)carroselView.CurrentItem;

        await Shell.Current.GoToAsync(nameof(PlayerPage));
    }

}

