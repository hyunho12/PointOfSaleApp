namespace PointOfSaleApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		if(DeviceInfo.Idiom == DeviceIdiom.Phone)
		{
			MainPage = new AppShellMobile();
		}
		else if(DeviceInfo.Idiom == DeviceIdiom.Tablet)
		{
			MainPage = new AppShell();
		}
		else
		{
            MainPage = new AppShell();
        }		
	}
}
