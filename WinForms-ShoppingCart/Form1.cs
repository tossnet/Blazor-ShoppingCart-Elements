using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace WinForms_ShoppingCart;

public partial class Form1 : Form {
	public Form1() {
		InitializeComponent();

		ServiceCollection services = new();
		services.AddWindowsFormsBlazorWebView();

		BlazorWebView blazorWebView = new() {
			HostPage = @"wwwroot\index.html",
			Services = services.BuildServiceProvider(),
			Dock = DockStyle.Fill,
		};

		blazorWebView.RootComponents.Add<Components.Index>("#app");

		Controls.Add(blazorWebView);
	}
}