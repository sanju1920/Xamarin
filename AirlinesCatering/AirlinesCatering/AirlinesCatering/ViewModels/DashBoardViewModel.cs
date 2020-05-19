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
        private readonly Users _currentUser;
        public DashBoardViewModel(INavigation navigation, AirlineContext context,Users users)
        {
            _navigation = navigation;
            _context = context;
            _boardServive = new DashBoardService(context);
            AddMealCommand = new Command(AddMeal);   
            _currentUser = users;
            UserName = _currentUser.Name;
            GetUserMeal();
        }

        public string UserName { set; get; }
        public List<MealListViewModel> UserMeals { set; get;}
        public Command AddMealCommand { get; }

        public void AddMeal()
        {
            _navigation.PushAsync(new AddEditMeal(_context, _currentUser, null));
        }
        public void GetUserMeal()
        {
            UserMeals = MealListViewModel.To(_navigation, _context, _currentUser, _boardServive.GetMeals());
        }
    }
}
