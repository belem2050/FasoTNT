namespace FasoTNT.Views.Pages;
using CommunityToolkit.Maui.Views;
using FasoTNT.ViewModels.Pages;

public partial class NowPage : ContentPage
{
	public NowPage()
	{
		InitializeComponent();
		BindingContext = new NowPageVM();
	}
}