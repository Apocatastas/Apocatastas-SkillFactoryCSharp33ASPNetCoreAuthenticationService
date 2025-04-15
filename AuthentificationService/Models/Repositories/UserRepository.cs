namespace AuthentificationService.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            var users = new List<User>()
            {
                #region Users
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Xiron",
                    LastName = "Inferno",
                    Email = "Xiron@inferno.ee",
                    Password = "password",
                    Login = "Xiron",
                    Role = new Role() {
                      Id = 2,
                      Name = "Администратор"
                    }
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Olema",
                    LastName = "Dark",
                    Email = "olema@cabba.la",
                    Password = "password",
                    Login = "Olema",
                    Role = new Role() {
                      Id = 2,
                      Name = "Администратор"
                    }
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Axis",
                    LastName = "Heretic",
                    Email = "axis@might.me",
                    Password = "password",
                    Login = "Axis",
                    Role = new Role() {
                      Id = 1,
                      Name = "Пользователь"
                    }
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Xarfax",
                    LastName = "Overlord",
                    Email = "xarfax@fluffy.be",
                    Password = "password",
                    Login = "Xarfax",
                    Role = new Role() {
                      Id = 1,
                      Name = "Пользователь"
                    }
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Zydar",
                    LastName = "Mighty",
                    Email = "zydar@lead.no",
                    Password = "password",
                    Login = "Zydar",
                    Role = new Role() {
                      Id = 1,
                      Name = "Пользователь"
                    }
                },
                #endregion
            };
            return users;
        }

        public User GetByEmail(string email)
        {
            var users = GetAll();
            return users.FirstOrDefault(x => x.Email == email);
        }

        public User GetByLogin(string login)
        {
            var users = GetAll();
            return users.FirstOrDefault(x => x.Login == login);
        }
    }
}
