using AirlinesCatering.Views;
using SqliteApp.Standard;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirlinesCatering
{
    public partial class App : Application
    {
        public App(AirlineContext context)
        {
            InitializeComponent();

            MainPage = new Login(context);
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
