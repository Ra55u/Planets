using TARpe22MauiPlanets.Models;
using TARpe22MauiPlanets.Services;

namespace TARpe22MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
	public PlanetsPage()
	{
		InitializeComponent();

		lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
		lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
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