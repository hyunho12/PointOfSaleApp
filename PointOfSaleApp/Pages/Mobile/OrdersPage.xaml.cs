using PointOfSaleApp.ViewModels;

namespace PointOfSaleApp.Pages.Mobile;

public partial class OrdersPage : ContentPage
{
	public OrdersPage()
	{
		InitializeComponent();
	}

	//public OrdersViewModel ViewModel;
	//public OrdersPage(OrdersViewModel vm)
	//{
	//	InitializeComponent();
	//	BindingContext = vm;
	//}
	//: 'No parameterless constructor defined for type 'Point Of Sale App.Pages.Mobile.Orders Page 
	// MauiProgram.cs에서 builder.Services.AddScope<OrdersPage,OrdersViewModel>(); 추가
}