using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsappDM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalPage : ContentPage
	{
		public PrincipalPage ()
		{
			InitializeComponent ();
		}

        async void OpenConfiguration()
        {
            await Navigation.PushModalAsync(new NavigationPage(new ConfigurationPage()));
        }

        void OpenEmpthyWhatsapp()
        {
            Device.OpenUri(new Uri("whatsapp://chat"));
        }
    }
}