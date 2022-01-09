using System;
using test1.Services;
using test1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Nunito-SemiBold.ttf", Alias = "Nun")]

namespace test1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
