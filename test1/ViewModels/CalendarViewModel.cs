using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using test1.Views;
using Xamarin.Forms;

namespace test1.ViewModels
{
    public class CalendarViewModel : BaseViewModel
    {
        public Command CalendarCommand { get; }
        public CalendarViewModel()
        {
            CalendarCommand = new Command(OnCalendarStartClicked);
        }
        private async void OnCalendarStartClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(ExercisesList)}");
        }
    }
}