using PointOfSaleApp.Pages.Mobile;

namespace PointOfSaleApp;

public partial class AppShellMobile : Shell
{
	public AppShellMobile()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(OrderDetailsPage), typeof(OrderDetailsPage));
		Routing.RegisterRoute(nameof(PayPage), typeof(PayPage));
		Routing.RegisterRoute(nameof(ReceiptPage), typeof(ReceiptPage));
		Routing.RegisterRoute(nameof(ScanPage), typeof(ScanPage));
		Routing.RegisterRoute(nameof(SignaturePage), typeof(SignaturePage));
		Routing.RegisterRoute(nameof(TipPage), typeof(TipPage));
	}
}
