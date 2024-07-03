namespace App_Cinopolis.Models;

public partial class pantalla_registro : ContentPage
{
    private bool isPasswordVisible = false;
    private bool isPasswordVisiblep = false;
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

    private void TogglePasswordVisibility(object sender, EventArgs e)
    {
        isPasswordVisible = !isPasswordVisible;

        // Cambia la visibilidad del texto de la contrase�a
        PasswordEntry.IsPassword = !isPasswordVisible;

        // Cambia el icono del bot�n para reflejar la visibilidad actual de la contrase�a
        if (isPasswordVisible)
        {
            TogglePasswordVisibilityIcon.Source = "clave.png";
        }
        else
        {
            TogglePasswordVisibilityIcon.Source = "noclave.png";
        }
    }

    private void TogglePasswordVisibilityIconp_Clicked(object sender, EventArgs e)
    {
        isPasswordVisiblep = !isPasswordVisiblep;

        // Cambia la visibilidad del texto de la contrase�a
        PasswordEntryp.IsPassword = !isPasswordVisiblep;

        // Cambia el icono del bot�n para reflejar la visibilidad actual de la contrase�a
        if (isPasswordVisiblep)
        {
            TogglePasswordVisibilityIconp.Source = "clave.png";
        }
        else
        {
            TogglePasswordVisibilityIconp.Source = "noclave.png";
        }
    }
}