using AirlinesCatering.ViewModels;
using SqliteApp.Standard;
using SqliteApp.Standard.Service;
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
    public partial class Login : ContentPage
    {
        public Login(AirlineContext context)
        {
            InitializeComponent();
            BindingContext = new  LoginViewModel(Navigation, context);
        }
       
    }
}