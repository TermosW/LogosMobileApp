using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using test1.Views;
using Xamarin.Forms;

namespace test1.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        public Command AcceptRegCommand { get; }
        public RegistrationViewModel()
        {
            AcceptRegCommand = new Command(OnAcceptRegClicked);
        }
        private async void OnAcceptRegClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(Calendar)}");
        }

    }
}