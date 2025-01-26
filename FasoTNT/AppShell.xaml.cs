using FasoTNT.Views.Pages;

namespace FasoTNT
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(NowPage), typeof(NowPage));
            Routing.RegisterRoute(nameof(TonigthPage), typeof(TonigthPage));
            Routing.RegisterRoute(nameof(PlayerPage), typeof(PlayerPage));
        }
    }
}
