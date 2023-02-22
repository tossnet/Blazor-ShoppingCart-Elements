namespace ShoppingCart.UI.Models;


public class Cart {

    public Cart() {
        SoftwareUnit = 1;
    }

    public int SoftwareUnit { get; set; }
    public int ModuleUnit { get; set; }
    public bool OptionUnit { get; set; }
    public int TrainingUnit { get; set; }
    public int PlanningViewer { get; set; }
}
