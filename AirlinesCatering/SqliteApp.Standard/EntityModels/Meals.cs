using System;
using System.ComponentModel.DataAnnotations;

namespace SqliteApp.Standard.EntityModels
{
    public class Meals
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public string MealType { set; get; }
        public bool IsActive { set; get; }
        public DateTime CreatedOnUtc { set; get; }
    }
}
