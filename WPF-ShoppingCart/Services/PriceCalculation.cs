namespace WPF_ShoppingCart.Services;

using WPF_ShoppingCart.Models;
using System;

public class PriceCalculation {

    public double Calculate(Cart panier) {

        panier.TotalAmount = panier.GetTotalSoftwarePrice();

        panier.TotalAmount += Convert.ToDouble(panier.OptionUnit) * panier.OptionUnitPrice;

        panier.TotalAmount += Convert.ToDouble(panier.ModuleUnit) * panier.ModuleUnitPrice;

        panier.TotalAmount += Convert.ToDouble(panier.TrainingUnit) * panier.TrainingUnitPrice;

        return panier.TotalAmount;
    }
}
