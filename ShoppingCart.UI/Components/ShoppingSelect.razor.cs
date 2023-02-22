namespace ShoppingCart.UI.Components;

using ShoppingCart.UI.Models;
using System;

public partial class ShoppingSelect {

    private Cart cart { get; set; } = new();

    private void SoftUnitChanged(int softunit) {
        cart.SoftwareUnit = softunit;

    }
    private void OptionChecked(bool valeur) {
        cart.OptionUnit = valeur;
        StateHasChanged();
    }

    private void ModuleUnitChanged(int module) {
        cart.ModuleUnit = module;
        StateHasChanged();
    }

    private void TrainingUnitChanged(int eForm) {
        cart.TrainingUnit = eForm;
        StateHasChanged();
    }
}
