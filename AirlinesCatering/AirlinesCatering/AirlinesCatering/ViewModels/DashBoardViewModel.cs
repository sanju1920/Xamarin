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
    public class DashBoardViewModel
    {
        public INavigation _navigation;
        private readonly AirlineContext _context;
        private readonly IDashBoardService _boardServive;
        public DashBoardViewModel(INavigation navigation, AirlineContext context)
        {
            _navigation = navigation;
            _context = context;
            _boardServive = new DashBoardService(context);
            AddMealCommand = new Command(AddMeal);
            UserMeals = _boardServive.GetMeals();
        }
        public string UserName { set; get; }
        public List<Meals> UserMeals { set; get;}
        public Command AddMealCommand { get; }

        public void AddMeal()
        {
            _navigation.PushAsync(new AddEditMeal(_context));
        }
    }
}
