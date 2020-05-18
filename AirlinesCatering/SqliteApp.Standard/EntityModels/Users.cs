using System;

namespace SqliteApp.Standard.EntityModels
{
    public class Users
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public int? Number { set; get; }
        public bool IsActive { set; get; }
        public DateTime CreatedOnUtc { set; get; }
    }
}
