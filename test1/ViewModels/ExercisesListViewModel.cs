using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using test1.Views;

namespace test1.ViewModels
{
    public class ExercisesListViewModel : BaseViewModel
    {
        public Command StartCommand { get; }
        public ExercisesListViewModel()
        {
            Title = "Тренировки";
            StartCommand = new Command(OnStartClicked);
        }

        private async void OnStartClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(FullExercise)}");
        }
    }
}