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
        public AddEditMealViewModel(INavigation navigation, AirlineContext context)
        {
            _navigation = navigation;
            _context = context;
            _boardServive = new DashBoardService(context);
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
        }

        public void EditMode(Meals meals)
        {
            Name = meals.Name;
            MealType = meals.MealType;
            Title = "Edit Meal";
        }
    }
}
