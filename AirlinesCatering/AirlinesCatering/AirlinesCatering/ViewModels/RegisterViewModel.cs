using AirlinesCatering.Views;
using SqliteApp.Standard;
using SqliteApp.Standard.EntityModels;
using SqliteApp.Standard.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirlinesCatering.ViewModels
{
   public class RegisterViewModel
    {
        public INavigation _navigation;
        private readonly AirlineContext _context;
        private readonly ILoginRegisterService _register;
        public RegisterViewModel(INavigation navigation, AirlineContext context)
        {
            _navigation = navigation;
            _context = context;
            _register = new LoginRegisterService(context);
            SignUpCommand = new Command(Register);
            LoginCommand = new Command(SignInPage);
        }

        public string Name { set; get; }
        public string Password { set; get; }
        public int? Number { set; get; }
        public string Email { set; get; }

        public Command SignUpCommand { get; }
        public Command LoginCommand { get; }

        public void Register()
        {
            Users users = new Users();
            users.Name = Name;
            users.Password = Password;
            users.Email = Email;
            users.Number = Number;
            users.IsActive = true;
            users.CreatedOnUtc = DateTime.UtcNow;

            var status =_register.Register(users);
            if (status)
            {
                _navigation.PushAsync(new Login(_context));
            }
            else
            {

            }
            
        }

        private void SignInPage(object obj)
        {
            _navigation.PushAsync(new Login(_context));
        }
    }
}
