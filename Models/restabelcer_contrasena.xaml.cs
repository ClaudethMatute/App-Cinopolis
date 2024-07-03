namespace App_Cinopolis.Models;

public partial class restabelcer_contrasena : ContentPage
{
	public restabelcer_contrasena()
	{
		InitializeComponent();
	}

    private async void btnEnviar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Verificar_contrasena());
    }
}