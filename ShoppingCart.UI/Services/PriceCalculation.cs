namespace ShoppingCart.UI.Services;

using ShoppingCart.UI.Models;

public class PriceCalculation {

    public double Calculate(Cart panier) {

        double amount = panier.GetTotalSoftwarePrice();

        amount += Convert.ToDouble(panier.OptionUnit) * panier.OptionUnitPrice;

        amount += Convert.ToDouble(panier.ModuleUnit) * panier.ModuleUnitPrice;

        amount += Convert.ToDouble(panier.TrainingUnit) * panier.TrainingUnitPrice;

        return amount;
    }
}
