using Xamarin.Forms;
using Prism.Unity;
using Prism.Mvvm;
using Diplomado.Views;

namespace Diplomado
{
	public partial class App : PrismApplication
	{
		public App()
		{
			InitializeComponent();
		}

		protected override void OnInitialized()
		{

			NavigationService.NavigateAsync("DashboardPage");

		}

		protected override void RegisterTypes()
		{

			Container.RegisterTypeForNavigation<DashboardPage>();
			Container.RegisterTypeForNavigation<DestinationPage>();
		}


	}
}
