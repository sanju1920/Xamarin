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
    public class MealListViewModel
    {
        public Meals Meal { get; set; }

        public Command EditMealCommmand { get; }
        public Command DeleteMealCommand { get; }

        private INavigation _navigation;
        private readonly AirlineContext _context;
        private  readonly IDashBoardService  _boardService;
        private readonly Users _currentUser;
        public MealListViewModel(INavigation navigation, AirlineContext context, Users users,Meals meal)
        {
            _navigation = navigation;
            _context = context;
            Meal = meal;
            _currentUser = users;
            _boardService = new DashBoardService(_context);
            EditMealCommmand = new Command(EditMeal);
            DeleteMealCommand = new Command(DeleteMeal);
        }

        private void DeleteMeal(object obj)
        {
            _boardService.DeleteMealById(Meal.Id);
            _navigation.PopAsync();
            _navigation.PushAsync(new DashBoard(_context, _currentUser));
            
        }

        private void EditMeal(object obj)
        {
            _navigation.PushAsync(new AddEditMeal(_context,_currentUser,Meal));
        }
        public static List<MealListViewModel> To(INavigation navigation, AirlineContext context, Users users, List<Meals> meals)
        {
            var destination = new List<MealListViewModel>();
            foreach(var meal in meals)
            {
                destination.Add(new MealListViewModel(navigation,context,users,meal));
            }

            return destination;
        }
    }
}
