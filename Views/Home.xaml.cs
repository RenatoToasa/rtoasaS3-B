namespace rtoasaS3.Views;

public partial class Home : ContentPage
{
	public Home(string nombre)
	{
		InitializeComponent();
		lblNombre.Text = "bienvenido "+nombre;
	}
}