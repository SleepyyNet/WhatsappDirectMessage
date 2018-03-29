using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace WhatsappDM.ViewModels
{
    public class AboutViewModel : ContentPage
    {
        public ICommand OpenWebCommand { get; }

        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://blog.viviecar.com/es/")));
        }
    }
}