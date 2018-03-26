using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsappDM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
            Title = "About";
		}
	}
}