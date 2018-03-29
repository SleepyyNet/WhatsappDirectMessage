using System;
using System.Windows.Input;
using WhatsappDM.Views;
using Xamarin.Forms;

namespace WhatsappDM.ViewModels
{
    public class PrincipalViewModel : ContentPage
    {
        public ICommand OpenWebCommand { get; }

        public PrincipalViewModel()
        {
            Title = "WhatsappDM";
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("whatsapp://send?phone=18099845274")));
        }
    }
}
