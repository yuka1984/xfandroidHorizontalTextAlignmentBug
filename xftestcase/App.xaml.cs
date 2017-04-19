using Xamarin.Forms;
using xftestcase;

namespace xftestcase
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabpage = new TabbedPage();

			var page1 = new MyPage() { 
				Title = "Page1"
			};
			var page2 = new MyPage() { 
				Title = "Page2"
			};

			tabpage.Children.Add(page1);
			tabpage.Children.Add(page2);

			MainPage = tabpage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
