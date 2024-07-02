
namespace App_Cinopolis.Models;

public partial class pantalla_inicio : ContentPage
{
	public pantalla_inicio()
	{
		InitializeComponent();

    }


    private async void btnRegistro_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new pantalla_registro());
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new cinépolis_login());
    }
}