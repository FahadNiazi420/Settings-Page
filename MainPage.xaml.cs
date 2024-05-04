//using Xamarin.Forms;



namespace EditPages
{
	public partial class MainPage : ContentPage
	{
		private NavigationService _navigationService;
		public MainPage()
		{
			InitializeComponent();
			_navigationService = new NavigationService();
		}
		private async void OnEditProfileClickedAsync(object sender, EventArgs e)
		{
			await _navigationService.NavigateToAsync("///EditProfile");
		}

		// NavigationService implementation
		public class NavigationService
		{
			public async Task NavigateToAsync(string pageName)
			{
				// Implement your navigation logic here
				// For example, using Shell Navigation:
				await Shell.Current.GoToAsync(pageName);
			}
		}




	}

}
