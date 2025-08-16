namespace MauiAppHotel.Views;

public partial class Contratacao : ContentPage
{
	App PropriedadesApp;

	public Contratacao()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pckQuarto.ItemsSource = PropriedadesApp.listaQuartos;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Contratada());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops!", ex.Message, "Ok");
		}
    }
}