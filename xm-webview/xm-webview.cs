using System;

using Xamarin.Forms;

namespace xmwebview
{
	public class App : Application
	{
		public App ()
		{
			WebView webView = new WebView {
				Source = new UrlWebViewSource {
					Url = "http://192.168.251.1:5000/test"
				},
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Blue
			};

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.FillAndExpand,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!",
							TextColor = Color.White,
							HeightRequest = 30,
							BackgroundColor = Color.Pink,
						},
						webView
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

