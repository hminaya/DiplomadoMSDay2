using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace Diplomado.ViewModels
{
	public class DestinationPageViewModel: BindableBase,  INavigatedAware
	{
		INavigationService _navigationService;
		public DelegateCommand BackCommand { get; set;}

		private string _resultado;
		public string Resultado
		{
			get { return _resultado; }
			set { SetProperty(ref _resultado, value); }
		}

		public DestinationPageViewModel(INavigationService navigationService)
		{

			BackCommand = new DelegateCommand(OnBack);

			_navigationService = navigationService;

			Resultado = "--------------------";

		}

		void OnBack()
		{
			_navigationService.GoBackAsync();
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (parameters.ContainsKey("id"))
			{
				Resultado = (string)parameters["id"];

			}


		}
	}
}
