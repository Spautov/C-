using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersDAL.Repositories
{
    public class SessionsRepository : IRepository<Session>, IDisposable
    {
        private UsersDBEntities _usersDBEntities;

        public SessionsRepository()
        {
            _usersDBEntities = new UsersDBEntities();
        }
        public void Add(Session item)
        {
            _usersDBEntities.Sessions.Add(item);
            _usersDBEntities.SaveChanges();
        }

        public void Dispose()
        {
            _usersDBEntities.Dispose();
        }

        public IEnumerable<Session> Get()
        {
            return _usersDBEntities.Sessions.ToList();
        }

        public Session GetById(int id)
        {
            return _usersDBEntities.Sessions.FirstOrDefault(session => session.SessionId == id);
        }

        public Session GetByUserId(int id)
        {
            return _usersDBEntities.Sessions.FirstOrDefault(session => session.UserId == id);
        }

        public void Remove(Session item)
        {
            _usersDBEntities.Sessions.Remove(item);
            _usersDBEntities.SaveChanges();
        }

        public void Save()
        {
            _usersDBEntities.SaveChanges();
        }
    }
}
