using FasoTNT.ViewModels.Pages;

#if ANDROID
using Android.Content.PM;
#endif

namespace FasoTNT.Views.Pages;

public partial class PlayerPage : ContentPage
{
	public PlayerPage()
	{
		InitializeComponent();
		BindingContext = new PlayerPageVM();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

#if ANDROID

       Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Landscape;
#endif

		MediaPlayer.Play();
    }

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

#if ANDROID

       Platform.CurrentActivity.RequestedOrientation = ScreenOrientation.Unspecified;
#endif
        MediaPlayer.Stop();
    }
}