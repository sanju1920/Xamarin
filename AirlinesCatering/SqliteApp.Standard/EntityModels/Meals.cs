using System;

namespace SqliteApp.Standard.EntityModels
{
    public class Meals
    {
        public int Id { set; get; }
        public string MealName { set; get; }
        public string MealType { set; get; }
        public bool IsActive { set; get; }
        public DateTime CreatedOnUtc { set; get; }
        public DateTime? ModifiedOnUtc { set; get; }
        public int? ModifiedBy { set; get; }
        public int? CreatedBy { set; get; }
    }
}
