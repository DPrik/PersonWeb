using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

namespace DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private UserContext db = new UserContext();

        public UserRepository()
        {
        }
        UserContext context = new UserContext();
        public void Create(User item)
        {
            // context.Users.Add(item);
            context.Set<User>().Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = context.User.Find(id);
            if (user != null)
                context.User.Remove(user);
            context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {

            IEnumerable<User> var = context.User.ToList();
            return context.User.ToList();
        }

        public User Get(int id)
        {
            return context.User.Find(id);
        }
        public User GetByName(string name)
        {
            return context.User.Where(x => x.FirstName == name).FirstOrDefault();
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public User GetByRegId(string id)
        {
            return context.User.Where(x => x.RegId == id).FirstOrDefault();
        }

        public void Update(User item)
        {
           
          
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public User GetbyRegId(string id)
        {
            
                return context.User.Where(x => x.RegId == id).FirstOrDefault();
            
        }
    }
}
