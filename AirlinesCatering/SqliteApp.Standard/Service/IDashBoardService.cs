using SqliteApp.Standard.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteApp.Standard.Service
{
     public interface IDashBoardService
    {
        List<Meals> GetMeals();
        Meals GetMealById(int Id);
        bool UpdateMealById(Meals meal, int Id);
    }
}
