using quizApp_backend.Models;

namespace quizApp_backend.IServices
{
    public interface IUserServices
    {
        User Register(UserDto user);
        string Login(string password, User suser);
    }
}
