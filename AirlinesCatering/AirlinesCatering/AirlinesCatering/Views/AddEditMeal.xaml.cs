using AirlinesCatering.ViewModels;
using SqliteApp.Standard;
using SqliteApp.Standard.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirlinesCatering.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditMeal : ContentPage
    {
        public AddEditMeal(AirlineContext context, Users currentUser, Meals meal)
        {
            InitializeComponent();
            var viewModel = new AddEditMealViewModel(Navigation, context, currentUser);
            if (meal != null)
            {
                viewModel.EditMode(meal);
            }
            BindingContext = viewModel;
        }
    }
}