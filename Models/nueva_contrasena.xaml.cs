namespace App_Cinopolis.Models;

public partial class nueva_contrasena : ContentPage
{
    private bool isPasswordVisibleT = false;
    private bool isPasswordVisibleNC = false;
    private bool isPasswordVisibleVC = false;
    public nueva_contrasena()
	{
		InitializeComponent();
    }

    private void TogglePasswordVisibilityIconT_Clicked(object sender, EventArgs e)
    {
        isPasswordVisibleT = !isPasswordVisibleT;

        // Cambia la visibilidad del texto de la contraseña
        PasswordEntryT.IsPassword = !isPasswordVisibleT;

        // Cambia el icono del botón para reflejar la visibilidad actual de la contraseña
        if (isPasswordVisibleT)
        {
            TogglePasswordVisibilityIconT.Source = "clave.png";
        }
        else
        {
            TogglePasswordVisibilityIconT.Source = "noclave.png";
        }
    }

    private void TogglePasswordVisibilityIconNC_Clicked(object sender, EventArgs e)
    {
        isPasswordVisibleNC = !isPasswordVisibleNC;

        // Cambia la visibilidad del texto de la contraseña
        PasswordEntryNC.IsPassword = !isPasswordVisibleNC;

        // Cambia el icono del botón para reflejar la visibilidad actual de la contraseña
        if (isPasswordVisibleNC)
        {
            TogglePasswordVisibilityIconNC.Source = "clave.png";
        }
        else
        {
            TogglePasswordVisibilityIconNC.Source = "noclave.png";
        }

    }

    private void TogglePasswordVisibilityIconVC_Clicked(object sender, EventArgs e)
    {
        isPasswordVisibleVC = !isPasswordVisibleVC;

        // Cambia la visibilidad del texto de la contraseña
        PasswordEntryVC.IsPassword = !isPasswordVisibleVC;

        // Cambia el icono del botón para reflejar la visibilidad actual de la contraseña
        if (isPasswordVisibleVC)
        {
            TogglePasswordVisibilityIconVC.Source = "clave.png";
        }
        else
        {
            TogglePasswordVisibilityIconVC.Source = "noclave.png";
        }
    }

    private async void btnRestablecer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new pantalla_inicio());
    }
}