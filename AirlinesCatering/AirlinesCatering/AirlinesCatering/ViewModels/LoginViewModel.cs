using AirlinesCatering.Views;
using SqliteApp.Standard;
using SqliteApp.Standard.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirlinesCatering.ViewModels
{
    public class LoginViewModel
    {
        public INavigation _navigation;
        private readonly AirlineContext _context;
        private readonly ILoginRegisterService login;
        public LoginViewModel(INavigation navigation,AirlineContext context)
        {
            _navigation = navigation;
            _context = context;
            login = new LoginRegisterService(context);
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(SignUpPage);
        }
        public string UserId { set; get; }
        public string Password { set; get; }
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public void Login()
        {
            var userId = UserId;
            var password = Password;
            var user = login.GetUsers(userId, password);
            if(user!= null)
            {
                _navigation.PushAsync(new DashBoard(_context));
            }
            else
            {
                
            }      
        }

        public void SignUpPage()
        {
            _navigation.PushAsync(new Register(_context));
        }
    }
}
