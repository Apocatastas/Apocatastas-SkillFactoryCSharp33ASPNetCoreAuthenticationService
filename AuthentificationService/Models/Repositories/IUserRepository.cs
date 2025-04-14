namespace AuthentificationService.Models.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetByEmail(string login);
    }
}
