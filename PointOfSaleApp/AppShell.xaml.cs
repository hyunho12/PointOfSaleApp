namespace PointOfSaleApp;

public partial class AppShell : Shell
{
	private string selectedRoute;

	public AppShell()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public string SelectedRoute
	{
		get { return selectedRoute; }
		set
		{
			selectedRoute = value;			
		}
	}

	async void OnMenuItemChanged(Object sender, CheckedChangedEventArgs e)
	{
		if (!String.IsNullOrEmpty(selectedRoute))
		{
			await Shell.Current.GoToAsync($"//{selectedRoute}");
		}
	}
}
