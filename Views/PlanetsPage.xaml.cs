using Models;
using Services;

namespace Views;

public partial class PlanetsPage : ContentPage
{
	public PlanetsPage()
	{
		InitializeComponent();

		lstPopularPlanets.ItemsSource = PlanetService.GetFeaturedPlanets();
		lstAllPlanets.ItemsSource = PlanetService.GetAllPlanets();
	}

	async void GridArea_Tapped(System.Object sender, System.EventArgs e)
	{
		
	}

    private void ApiPic_Clicked(System.Object sender, System.EventArgs e)
    {

    }

	async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
        await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet));
    }
}