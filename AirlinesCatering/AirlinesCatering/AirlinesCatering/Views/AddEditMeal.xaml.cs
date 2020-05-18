﻿using AirlinesCatering.ViewModels;
using SqliteApp.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirlinesCatering.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditMeal : ContentPage
    {
        public AddEditMeal(AirlineContext context)
        {
            InitializeComponent();
            BindingContext = new AddEditMealViewModel(Navigation,context);
        }
    }
}