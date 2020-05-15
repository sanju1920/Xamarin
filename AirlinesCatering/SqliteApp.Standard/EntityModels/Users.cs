using System;

namespace SqliteApp.Standard.EntityModels
{
    public class Users
    {
        public int Id { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int RoleId { set; get; }
        public bool IsActive { set; get; }
        public DateTime CreatedOnUtc { set; get; }
        public DateTime? ModifiedOnUtc { set; get; }
        public DateTime DateOfBirth { set; get; }
    }
}
