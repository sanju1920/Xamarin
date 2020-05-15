using SqliteApp.Standard.EntityModels;
using System;
using System.Linq;

namespace SqliteApp.Standard.Service
{
    public class LoginRegister : ILoginRegister
    {
        private AirlineContext _airlineContext;
        public LoginRegister()
        {
            _airlineContext =new  AirlineContext();
        }

        public  Users GetUsers(string userId, string password)
        {
            return _airlineContext.Users.
                Where(x=> (x.UserName == userId) && x.Password ==password)
                .FirstOrDefault();
        }

        public bool Register(Users users)
        {
            bool status = false;
            try
            {
                _airlineContext.Users.Add(users);
                _airlineContext.SaveChanges();
                status = true;
            }
            catch (Exception)
            {              
            }
            return status;
        }
    }
}
