using Xamarin.Forms;
using AppServiceHelpers;

namespace Futbolochka
{
	public partial class App : Application
	{
		public App () {
			InitializeComponent ();


			var client = EasyMobileServiceClient.Create ();

			client.Initialize ("https://chepohavat.azurewebsites.net");

			client.RegisterTable<Havka> ();

			client.FinalizeSchema ();

			MainPage = new NavigationPage(new HavkaPage (client));
		}

		protected override void OnStart () {
			// Handle when your app starts
		}

		protected override void OnSleep () {
			// Handle when your app sleeps
		}

		protected override void OnResume () {
			// Handle when your app resumes
		}
	}
}

