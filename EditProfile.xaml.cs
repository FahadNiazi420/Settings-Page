using Microsoft.Maui.Controls;


namespace EditPages
{
	public partial class EditProfile : ContentPage
	{
		private NavigationService _navigationService;
		public EditProfile()
		{
			InitializeComponent();
			_navigationService = new NavigationService();
		}
		private async void OnBackButtonClicked(object sender, EventArgs e)
		{
			// Navigate to the MainPage
			await Shell.Current.GoToAsync("///MainPage");
		}

		private async void OnEditProfileClickedAsync(object sender, EventArgs e)
		{
			// Navigate to the EditProfile page
			await Shell.Current.GoToAsync("///MainPage");
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

		private async void OnProfileImageButtonClicked(object sender, EventArgs e)
		{
			var result = await FilePicker.PickAsync(new PickOptions
			{
				FileTypes = FilePickerFileType.Images,
				PickerTitle = "Select Image"
			});

			if (result != null)
			{
				var stream = await result.OpenReadAsync();

				// Convert the stream to a byte array
				byte[] imageBytes;
				using (MemoryStream ms = new MemoryStream())
				{
					await stream.CopyToAsync(ms);
					imageBytes = ms.ToArray();
				}

				// Convert the byte array to a Xamarin.Forms.ImageSource
				ImageSource imageSource = ImageSource.FromStream(() => new MemoryStream(imageBytes));

				// Set the ImageSource to the ProfileImageButton
				ProfileImageButton.Source = imageSource;
			}
		}
	}



}