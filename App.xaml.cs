﻿namespace EditPages
{
	public partial class App : Application
	{
		public App()
		{
			Application.Current.UserAppTheme = AppTheme.Light;
			InitializeComponent();

			MainPage = new AppShell();
		}
	}
}
