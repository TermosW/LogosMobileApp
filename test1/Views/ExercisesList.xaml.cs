using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using test1.ViewModels;

namespace test1.Views
{
    public partial class ExercisesList : ContentPage
    {
        public ExercisesList()
        {
            InitializeComponent();
            this.BindingContext = new ExercisesListViewModel();
        }

        protected override void OnAppearing()
        {
            ExDictionary.exElements();

            ex1Title.Text = ExDictionary.Exercises[0].Title;
            ex1Text.Text = ExDictionary.Exercises[0].Text.Substring(0, 50) + " ...";
            ex1Time.Text = ExDictionary.Exercises[0].Time.ToString() + " сек";

            ex2Title.Text = ExDictionary.Exercises[1].Title;
            ex2Text.Text = ExDictionary.Exercises[1].Text.Substring(0, 47) + " ...";
            ex2Time.Text = ExDictionary.Exercises[1].Time.ToString() + " сек";

            ex3Title.Text = ExDictionary.Exercises[2].Title;
            ex3Text.Text = ExDictionary.Exercises[2].Text.Substring(0, 50) + " ...";
            ex3Time.Text = ExDictionary.Exercises[2].Time.ToString() + " сек";

            ex4Title.Text = ExDictionary.Exercises[3].Title;
            ex4Text.Text = ExDictionary.Exercises[3].Text.Substring(0, 50) + " ...";
            ex4Time.Text = ExDictionary.Exercises[3].Time.ToString() + " сек";

            ex5Title.Text = ExDictionary.Exercises[4].Title;
            ex5Text.Text = ExDictionary.Exercises[4].Text.Substring(0, 50) + " ...";
            ex5Time.Text = ExDictionary.Exercises[4].Time.ToString() + " сек";

            base.OnAppearing();
        }
    }
}