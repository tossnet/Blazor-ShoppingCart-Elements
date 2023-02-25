namespace WPF_ShoppingCart;

using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Shapes;
using ShoppingCart.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView();
        Resources.Add("services", serviceCollection.BuildServiceProvider());

        InitializeComponent();

    }
}
