namespace App_Cinopolis.Models;

public partial class pantalla_registro : ContentPage
{
	public pantalla_registro()
	{
		InitializeComponent();
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {

    }

    private async void btnCancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new pantalla_inicio());
    }
}