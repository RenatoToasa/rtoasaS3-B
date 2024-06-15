namespace rtoasaS3.Views;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario= txtUsuario.Text;
		string contrasena = txtContrasena.Text;
		DisplayAlert("ALERTA", "USUARIO GUARDADO", "OK");
		Navigation.PushAsync(new login(usuario, contrasena));

    }
}