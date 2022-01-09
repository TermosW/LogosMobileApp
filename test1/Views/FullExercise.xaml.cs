using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FullExercise : ContentPage
    {
        public FullExercise()
        {
            InitializeComponent();
            this.BindingContext = new FullExerciseViewModel();
        }

        //protected override void OnAppearing()
        //{
        //    i = 0;
        //    arrowLeft.IsEnabled = false;
        //    arrowLeft.Opacity = 0;

        //    exText.Text = ExDictionary.Exercises[0].Text;
        //    i = 0;

        //    base.OnAppearing();
        //}

        //void OnImageArrowLeftTapped(object sender, EventArgs args)
        //{
        //    try
        //    {
        //        i--;
        //        exText.Text = ExDictionary.Exercises[i].Text;
        //        arrowRight.IsEnabled = true;
        //        arrowRight.Opacity = 1;
        //        if (i == 0)
        //        {
        //            arrowLeft.IsEnabled = false;
        //            arrowLeft.Opacity = 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //void OnImageArrowRightTapped(object sender, EventArgs args)
        //{
            
        //    try
        //    {
        //        i++;
        //        arrowLeft.IsEnabled = true;
        //        arrowLeft.Opacity = 1;
        //        exText.Text = ExDictionary.Exercises[i].Text;
        //        if (i == 5)
        //        {
        //            arrowRight.IsEnabled = false;
        //            arrowRight.Opacity = 0;
        //        }
                
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}