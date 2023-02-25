namespace WPF_ShoppingCart.Models;

public class Cart {

    private const double DISCOUNT2 = 0.80;
    private const double DISCOUNT3 = 0.65;
    private const double DISCOUNT4 = 0.55;
    private const double DISCOUNT5 = 0.50;

    public Cart() {
        SoftwareUnit = 1;
        SoftwareUnitPrice = 999.0;
        OptionUnitPrice = 999.0;
        ModuleUnitPrice = 999.0;
        TrainingUnitPrice = 999.0;
    }

    public double GetSoftwarePrice(int licence) {
        return licence switch {
            2 => SoftwareUnitPrice * DISCOUNT2,
            3 => SoftwareUnitPrice * DISCOUNT3,
            4 => SoftwareUnitPrice * DISCOUNT4,
            5 => SoftwareUnitPrice * DISCOUNT5,
            _ => SoftwareUnitPrice,
        };
    }

    public double GetTotalSoftwarePrice() {
        return SoftwareUnit switch {
            2 => SoftwareUnitPrice * (1 + DISCOUNT2),
            3 => SoftwareUnitPrice * (1 + DISCOUNT2 + DISCOUNT3),
            4 => SoftwareUnitPrice * (1 + DISCOUNT2 + DISCOUNT3 + DISCOUNT4),
            5 => SoftwareUnitPrice * (1 + DISCOUNT2 + DISCOUNT3 + DISCOUNT4 + DISCOUNT5),
            _ => SoftwareUnitPrice,
        };
    }

    public double SoftwareUnitPrice { get; set; }
    public double OptionUnitPrice { get; set; }
    public double ModuleUnitPrice { get; set; }
    public double TrainingUnitPrice { get; set; }

    public int SoftwareUnit { get; set; }
    public int ModuleUnit { get; set; }
    public bool OptionUnit { get; set; }
    public int TrainingUnit { get; set; }
    public int PlanningViewer { get; set; }

    public double TotalAmount { get; set; }
}
