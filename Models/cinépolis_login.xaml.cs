namespace App_Cinopolis.Models;

public partial class cinépolis_login : ContentPage
{
    private bool isPasswordVisible = false;
    public cinépolis_login()
	{
		InitializeComponent();
	}

    private async void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new restabelcer_contrasena()); // Replace ForgotPasswordPage with your actual page name
    }

    private async void btnCrearU_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new pantalla_registro());
    }

    private async void btnRestablecer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new restabelcer_contrasena());
    }

    private void TogglePasswordVisibility(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;

        // Cambia la visibilidad del texto de la contraseña
        PasswordEntry.IsPassword = !isPasswordVisible;

        // Cambia el icono del botón para reflejar la visibilidad actual de la contraseña
        if (isPasswordVisible)
        {
            TogglePasswordVisibilityIcon.Source = "clave.png";
        }
        else
        {
            TogglePasswordVisibilityIcon.Source = "noclave.png";
        }
    }
}