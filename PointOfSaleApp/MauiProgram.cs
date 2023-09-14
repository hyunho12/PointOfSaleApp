using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PointOfSaleApp.Pages.Mobile;
using PointOfSaleApp.ViewModels;

namespace PointOfSaleApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("fa_solid.ttf", "FontAwesome");
				fonts.AddFont("fabmd12", "Fabric");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Services.AddScoped<OrdersPage, OrdersViewModel>();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
