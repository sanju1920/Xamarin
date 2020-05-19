using AirlinesCatering.Views;
using SqliteApp.Standard;
using SqliteApp.Standard.EntityModels;
using SqliteApp.Standard.Service;
using Xamarin.Forms;

namespace AirlinesCatering.ViewModels
{
    public class AddEditMealViewModel
    {
        public INavigation _navigation;
        private readonly AirlineContext _context;
        private readonly IDashBoardService _boardServive;
        private readonly Users _currentUser;
        public AddEditMealViewModel(INavigation navigation, AirlineContext context,Users users)
        {
            _navigation = navigation;
            _context = context;
            _boardServive = new DashBoardService(context);
            _currentUser = users;
            SaveCommand = new Command(Save);
            Title = "Add New Meal";
        }

        public Command SaveCommand { get; }
        public string Name { set; get; }
        public string MealType { set; get; }
        public string Title { set; get; }
        public int Id { set; get; }

        public void Save()
        {
            var user = new Meals
            {
                Name = Name,
                MealType = MealType
            };
            _boardServive.UpdateMealById(user, Id);
            _navigation.PopAsync();
            _navigation.PushAsync(new DashBoard(_context, _currentUser));
        }

        public void EditMode(Meals meals)
        {
            Name = meals.Name;
            MealType = meals.MealType;
            Id = meals.Id;
            Title = "Edit Meal";
        }
    }
}
