using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace WhatsappDM.ViewModels
{
    public class AboutViewModel : ContentPage
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://viviecar.com")));
        }

        public ICommand OpenWebCommand { get; }
    }
}