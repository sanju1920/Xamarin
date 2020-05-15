using SqliteApp.Standard.EntityModels;

namespace SqliteApp.Standard.Service
{
    public interface ILoginRegister
    {
        Users GetUsers(string userId , string password);
        bool Register(Users users);
    }
}
