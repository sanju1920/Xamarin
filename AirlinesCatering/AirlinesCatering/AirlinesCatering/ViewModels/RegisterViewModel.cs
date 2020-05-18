using AirlinesCatering.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirlinesCatering.ViewModels
{
   public class RegisterViewModel:MasterDetailPage
    {
        public INavigation _navigation;
        public RegisterViewModel(INavigation navigation)
        {
            _navigation = navigation;
            SignUpCommand = new Command(Register);
        }
        public string Name { set; get; }
        public string Password { set; get; }
        public int? Number { set; get; }
        public string Email { set; get; }

        public Command SignUpCommand { get; }

        public void Register()
        {
            _navigation.PushAsync(new Login());
        }
    }
}
