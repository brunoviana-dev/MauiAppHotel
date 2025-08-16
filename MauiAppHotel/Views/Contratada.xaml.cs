namespace MauiAppHotel.Views;

public partial class Contratada : ContentPage
{
	public Contratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops!", ex.Message, "Ok");
		}
    }
}