namespace App_Cinopolis.Models;

public partial class Verificar_contrasena : ContentPage
{
	public Verificar_contrasena()
	{
		InitializeComponent();
	}
    private void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        // L�gica para reenviar el c�digo de verificaci�n
    }

    private async void btnVerificar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new nueva_contrasena());
    }
}