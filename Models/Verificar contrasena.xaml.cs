namespace App_Cinopolis.Models;

public partial class Verificar_contrasena : ContentPage
{
	public Verificar_contrasena()
	{
		InitializeComponent();
	}
    private void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        // Lógica para reenviar el código de verificación
    }

    private async void btnVerificar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new nueva_contrasena());
    }
}