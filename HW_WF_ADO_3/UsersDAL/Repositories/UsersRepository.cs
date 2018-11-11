using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersDAL.Repositories
{
    public class UsersRepository : IRepository<User>, IDisposable
    {
        private UsersDBEntities _usersDBEntities;

        public UsersRepository()
        {
            _usersDBEntities = new UsersDBEntities();
        }
        public void Add(User item)
        {
            _usersDBEntities.Users.Add(item);
            _usersDBEntities.SaveChanges();
        }

        public void Dispose()
        {
            _usersDBEntities.Dispose();
        }

        public IEnumerable<User> Get()
        {
            return _usersDBEntities.Users.ToList();
        }

        public User GetById(int id)
        {
            return _usersDBEntities.Users.FirstOrDefault(user => user.UserId == id);
        }
        public User GetByEmail(string email)
        {
            return _usersDBEntities.Users.FirstOrDefault(user => user.Email.Equals(email));
        }
        public User GetByLogin(string login)
        {
            return _usersDBEntities.Users.FirstOrDefault(user => user.Login.Equals(login));
        }

        public void Remove(User item)
        {
            _usersDBEntities.Users.Remove(item);
            _usersDBEntities.SaveChanges();
        }

        public void Save()
        {
            _usersDBEntities.SaveChanges();
        }
    }
}
