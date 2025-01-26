using FasoTNT.ViewModels.Pages;

namespace FasoTNT.Views.Pages;

public partial class TonigthPage : ContentPage
{
	public TonigthPage()
	{
		InitializeComponent();
		BindingContext = new TonightPageVM();
	}
}