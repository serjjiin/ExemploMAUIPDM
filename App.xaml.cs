using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace ExemploMAUIPDM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Define a página inicial do aplicativo como uma NavigationPage que contém uma MainPage
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
