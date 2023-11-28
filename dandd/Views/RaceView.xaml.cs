using dandd.Models;

namespace dandd.Views;

public partial class RaceView : ContentPage
{
	public RaceView()
	{
		InitializeComponent();
		var race = new Race
		{
			RaceId = 1,	
			Name = "Dragonborn"
		};
		BindingContext= race;
	}
}