namespace App_Cinopolis.Models;

public partial class Verificar_contrasena : ContentPage
{
	public Verificar_contrasena()
	{
		//InitializeComponent();
	}
    private async void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Verificar_contrasena()); // Replace ForgotPasswordPage with your actual page name
    }
}