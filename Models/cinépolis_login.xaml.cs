namespace App_Cinopolis.Models;

public partial class cinépolis_login : ContentPage
{
	public cinépolis_login()
	{
		InitializeComponent();
	}

    private async void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new restabelcer_contrasena()); // Replace ForgotPasswordPage with your actual page name
    }
}