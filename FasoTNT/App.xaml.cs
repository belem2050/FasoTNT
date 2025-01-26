using FasoTNT.Views.Pages;

namespace FasoTNT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
