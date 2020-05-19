﻿using AirlinesCatering.ViewModels;
using SqliteApp.Standard;
using SqliteApp.Standard.EntityModels;
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
    public partial class DashBoard : ContentPage
    {
        public DashBoard(AirlineContext context,Users users)
        {
            InitializeComponent();
            BindingContext = new DashBoardViewModel(Navigation,context,users);
        }
    }
}