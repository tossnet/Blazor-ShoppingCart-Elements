namespace WPF_ShoppingCart.Components;

using Microsoft.AspNetCore.Components;
using ShoppingCart.UI.Models;
using ShoppingCart.UI.Services;
using System.Threading.Tasks;
using System.Windows;

public partial class ShoppingSelect {

    [Parameter]
    public double SoftwareUnitPrice { get; set; } = 999;

    [Parameter]
    public double OptionUnitPrice { get; set; } = 999;

    [Parameter]
    public double ModuleUnitPrice { get; set; } = 999;

    [Parameter]
    public double TrainingUnitPrice { get; set; } = 75;

    [Parameter]
    public EventCallback<Cart> CartValidated { get; set; }



    private Cart Cart { get; set; } = new();
    private PriceCalculation PriceCalculation { get; set; } = new();

    private int ModuleUnit {
        get => Cart.ModuleUnit;
        set {
            Cart.ModuleUnit = value;

            ComputePrice();
        }
    }

    protected override void OnParametersSet() {

        Cart.SoftwareUnitPrice = SoftwareUnitPrice;
        Cart.OptionUnitPrice = OptionUnitPrice;
        Cart.ModuleUnitPrice = ModuleUnitPrice;
        Cart.TrainingUnitPrice = TrainingUnitPrice;

        ComputePrice();

        base.OnParametersSet();
    }

    private void SoftUnitChanged(int softunit) {
        Cart.SoftwareUnit = softunit;

        ComputePrice();
    }

    private void OptionChecked(ChangeEventArgs e) {
        Cart.OptionUnit = (bool)e.Value;

        ComputePrice();
    }

    private void TrainingUnitChanged(ChangeEventArgs e) {
        Cart.TrainingUnit = int.Parse(e.Value.ToString());

        ComputePrice();
    }

    private string GetLabelQuantity(int quantity) {
        return quantity > 1 ? $"{quantity} unités" : "1 unité";
    }

    private void ComputePrice() {
        Cart.TotalAmount = PriceCalculation.Calculate(Cart);
    }

    private async Task NextStep() {

        string messageBoxText = $"Total cart : {Cart.TotalAmount}";
        string caption = "Shopping";
        MessageBoxButton button = MessageBoxButton.YesNoCancel;
        MessageBoxImage icon = MessageBoxImage.Question;
        MessageBoxResult result;

        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
    }

}
