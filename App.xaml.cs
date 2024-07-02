using App_Cinopolis.Models;

namespace App_Cinopolis
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            // MainPage = new NavigationPage(new Models.pantalla_inicio());
            // MainPage = new NavigationPage(new Models.cinépolis_login());

            //  MainPage = new NavigationPage(new Models.restabelcer_contrasena());
            MainPage = new NavigationPage(new Models.nueva_contrasena());
          //  MainPage = new NavigationPage(new Models.Verificar_contrasena());
            //MainPage = new NavigationPage(new Models.pantalla_registro());
        }
    }
}
