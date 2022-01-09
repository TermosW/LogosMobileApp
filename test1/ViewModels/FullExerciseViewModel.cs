using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using test1.Views;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using System.Timers;

namespace test1.ViewModels
{
    public class FullExerciseViewModel : BaseViewModel, INotifyPropertyChanged
    {
        public Command FullExerciseCommand { get; }

        public Command TimerCommand { get; }

        ICommand imageArrowRightTapped;
        public ICommand ImageArrowRightTapped { get { return imageArrowRightTapped; } }

        ICommand imageArrowLeftTapped;
        public ICommand ImageArrowLeftTapped { get { return imageArrowLeftTapped; } }

        public Timer OurTimer = new Timer(1000);

        private string opacityRight;
        public string OpacityRight
        {
            get => opacityRight;
            set
            {
                opacityRight = value;
                OnPropertyChanged(nameof(OpacityRight));
            }
        }

        private string opacityLeft = "0";
        public string OpacityLeft
        {
            get => opacityLeft;
            set
            {
                opacityLeft = value;
                OnPropertyChanged(nameof(OpacityLeft));
            }
        }

        private bool isEnabledRight = true;
        public bool IsEnabledRight
        {
            get => isEnabledRight;
            set
            {
                isEnabledRight = value;
                OnPropertyChanged(nameof(IsEnabledRight));
            }
        }

        private bool isEnabledLeft = false;
        public bool IsEnabledLeft
        {
            get => isEnabledLeft;
            set
            {
                isEnabledLeft = value;
                OnPropertyChanged(nameof(IsEnabledLeft));
            }
        }


        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }


        private string exText;
        public string ExText
        {
            get => exText;
            set
            {
                exText = value;
                OnPropertyChanged(nameof(ExText));
            }
        }
        

        private string time;
        public string Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public int i=0;

        public static int secondsCount = 0;

        public bool isStop = true;

        public FullExerciseViewModel()
        {
            ExText = ExDictionary.Exercises[i].Text;
            Title = ExDictionary.Exercises[i].Title;
            Time = ExDictionary.Exercises[i].Time.ToString();
            imageArrowRightTapped = new Command(OnImageArrowRightTapped);
            imageArrowLeftTapped = new Command(OnImageArrowLeftTapped);
            TimerCommand = new Command(OnTimerCommand);
        }

        private void OnTimerCommand(object obj)
        {
            try
            {
                OurTimer.Enabled = true;
                OurTimer.AutoReset = true;
                if (isStop)
                {
                    OurTimer.Elapsed += OurTimerElapsed;
                    OurTimer.Start();
                    isStop = false;
                }
                else
                {
                    OurTimer.Elapsed -= OurTimerElapsed;
                    OurTimer.Stop();
                    isStop = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void OurTimerElapsed(object sender, ElapsedEventArgs e)
        {
            secondsCount++;
            if(ExDictionary.Exercises[i].Time == secondsCount)
            {
                OurTimer.Elapsed -= OurTimerElapsed;
                OurTimer.Stop();
                isStop = true;
                Time = "0"+(int.Parse(Time) - 1).ToString();
            }
            else
            {
                if((ExDictionary.Exercises[i].Time - secondsCount) < 10)
                {
                    Time = "0"+(ExDictionary.Exercises[i].Time - secondsCount).ToString();
                }
                else
                {
                    Time = (ExDictionary.Exercises[i].Time - secondsCount).ToString();
                }
                
            }
            
        }

        private void OnImageArrowRightTapped(object obj)
        {
            try
            {
                secondsCount = 0;
                OurTimer.Stop();
                i++;
                IsEnabledLeft = true;
                OpacityLeft = "1";
                ExText = ExDictionary.Exercises[i].Text;
                Title = ExDictionary.Exercises[i].Title;
                Time = ExDictionary.Exercises[i].Time.ToString();
                if (i == ExDictionary.Exercises.Length-1)
                {
                    IsEnabledRight = false;
                    OpacityRight = "0";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void OnImageArrowLeftTapped(object obj)
        {
            try
            {
                secondsCount = 0;
                OurTimer.Stop();
                i--;
                ExText = ExDictionary.Exercises[i].Text;
                Title = ExDictionary.Exercises[i].Title;
                Time = ExDictionary.Exercises[i].Time.ToString();
                IsEnabledRight = true;
                OpacityRight = "1";
                if (i == 0)
                {
                    IsEnabledLeft = false;
                    OpacityLeft = "0";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new
                PropertyChangedEventArgs(propertyName));
        }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(Calendar)}");
        }

    }
}