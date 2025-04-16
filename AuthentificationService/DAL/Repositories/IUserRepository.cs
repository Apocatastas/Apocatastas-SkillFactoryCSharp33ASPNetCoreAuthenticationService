using AuthentificationService.BLL.Models;

namespace AuthentificationService.DAL.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetByEmail(string login);
        User GetByLogin(string login);
    }
}
