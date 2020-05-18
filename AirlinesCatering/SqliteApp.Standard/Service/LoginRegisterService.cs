using SqliteApp.Standard.EntityModels;
using System;
using System.Linq;

namespace SqliteApp.Standard.Service
{
    public class LoginRegisterService : ILoginRegisterService
    {
        private AirlineContext _airlineContext;
        public LoginRegisterService(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }

        public  Users GetUsers(string email, string password)
        {
            return _airlineContext.Users.
                Where(x=> (x.Email == email) && x.Password ==password)
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
