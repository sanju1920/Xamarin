using SqliteApp.Standard.EntityModels;
using Xamarin.Forms;

namespace AirlinesCatering.ViewModels
{
    public class AddEditMealViewModel
    {
        public INavigation _navigation;
        public AddEditMealViewModel(INavigation navigation)
        {
            _navigation = navigation;
            SaveCommand = new Command(Save);
            Title = "Add New Meal";
        }

        public Command SaveCommand { get; }
        public string Name { set; get; }
        public string MealType { set; get; }
        public string Title { set; get; }

        public void Save()
        {

        }

        public void EditMode(Meals meals)
        {
            Name = meals.Name;
            MealType = meals.MealType;
            Title = "Edit Meal";
        }
    }
}
