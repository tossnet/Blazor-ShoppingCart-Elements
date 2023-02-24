namespace ShoppingCart.UI.Services;

using ShoppingCart.UI.Models;

public class PriceCalculation {

    public double Calculate(Cart panier) {

        panier.TotalAmount = panier.GetTotalSoftwarePrice();

        panier.TotalAmount += Convert.ToDouble(panier.OptionUnit) * panier.OptionUnitPrice;

        panier.TotalAmount += Convert.ToDouble(panier.ModuleUnit) * panier.ModuleUnitPrice;

        panier.TotalAmount += Convert.ToDouble(panier.TrainingUnit) * panier.TrainingUnitPrice;

        return panier.TotalAmount;
    }
}
