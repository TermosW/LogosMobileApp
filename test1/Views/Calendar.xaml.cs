﻿using System;
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
    public partial class Calendar : ContentPage
    {
        public Calendar()
        {
            InitializeComponent();
            this.BindingContext = new CalendarViewModel();
        }
    }
}