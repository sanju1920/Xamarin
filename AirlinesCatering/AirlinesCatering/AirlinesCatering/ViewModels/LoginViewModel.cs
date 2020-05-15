using AirlinesCatering.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirlinesCatering.ViewModels
{
    public class LoginViewModel
    {
        public INavigation _navigation;
        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LoginCommand = new Command(Login);
        }
        public string UserId { set; get; }
        public string Password { set; get; }
        public Command LoginCommand { get; }

        public void Login()
        {
            var userId = UserId;
            var password = Password;
            _navigation.PushAsync(new DashBoard());
        }
    }
}
