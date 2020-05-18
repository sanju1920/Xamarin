using AirlinesCatering.Views;
using SqliteApp.Standard.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirlinesCatering.ViewModels
{
    public class DashBoardViewModel
    {
        public INavigation _navigation;
        public DashBoardViewModel(INavigation navigation)
        {
            _navigation = navigation;
            AddMealCommand = new Command(AddMeal);
        }
        public string UserName { set; get; }
        public List<Meals> UserMeals { set; get;}
        public Command AddMealCommand { get; }

        public void AddMeal()
        {
            _navigation.PushAsync(new AddEditMeal());
        }
    }
}
