using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xftestcase
{
	public partial class MyPage : ContentPage
	{
		public MyPage()
		{
			InitializeComponent();
			MessagingCenter.Subscribe<MyPage>(this, "Set", (obj) => {
				BottomText.Text = DateTime.Now.ToString("hh:mm:ss");
			});

			SetButton.Clicked += (sender, e) => { 
				MessagingCenter.Send(this, "Set");
			};

			BottomText.Text = DateTime.Now.ToString("hh:mm:ss");
		}
	}
}
