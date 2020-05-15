using SqliteApp.Standard.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqliteApp.Standard.Service
{
    public class DashBoardService : IDashBoardService
    {
        public AirlineContext _airlineContext;
        public DashBoardService(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }

        public Meals GetMealById(int Id)
        {
            return _airlineContext.Meals.Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<Meals> GetMeals()
        {
            return _airlineContext.Meals.Where(x => x.IsActive).ToList();
        }

        public bool UpdateMealById(Meals meal, int Id)
        {
            bool status = false;
            var dbMeal = GetMealById(Id);
            if(dbMeal != null)
            {
                dbMeal.Name = meal.Name;
                dbMeal.MealType = meal.MealType;
                try
                {
                    _airlineContext.SaveChanges();
                    status = true;
                }
                catch { }
            }
            return status;
        }
    }
}
