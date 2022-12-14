using UnitsConverterApp.MVVM.ViewModels;
using UnitsConverterApp.MVVM.Views;

namespace UnitsConverterApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MenuView());
	}
}
