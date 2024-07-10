using Amazon.Library.Models;
using eCommerce.MAUI.ViewModels;
namespace eCommerce.MAUI.Views;

public partial class ShopProduct : ContentPage
{
    //private Cart2ViewModel cartViewModel2;

    public ShopProduct()
    {
        InitializeComponent();
        BindingContext = new CartViewModel();
            

    }
    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Shop");
    }

    private void TaxesClicked(object sender, EventArgs e)
    {
        (BindingContext as CartViewModel)?.ApplyTaxRate();
    }
    private void CheckoutClicked(object sender, EventArgs e)
    {
        (BindingContext as CartViewModel)?.Checkout();

    }
}

   

