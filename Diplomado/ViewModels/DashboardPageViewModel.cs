using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace Diplomado.ViewModels
{
	public class DashboardPageViewModel : BindableBase, IConfirmNavigation
	{

		IPageDialogService _pageDialogService;
		INavigationService _navigationService;

		public DelegateCommand NavigateCommand { get; set; }

		private string _title;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}


		public DashboardPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
		{
			Title = "Soy el boton....";
			NavigateCommand = new DelegateCommand(OnNavigate);


			_navigationService = navigationService;
			_pageDialogService = pageDialogService;
		}

		void OnNavigate()
		{

			var pars = new NavigationParameters();

			pars.Add("id", Title);

			_navigationService.NavigateAsync("DestinationPage", pars);
							  
		}

		public bool CanNavigate(NavigationParameters parameters)
		{

			if (Title.Length == 0)
			{

				_pageDialogService.DisplayAlertAsync("Error", "No tienes parametros", "Ok");

				return false;
			} else
			{
				//SI
				return true;
			}

		}
	}
}
