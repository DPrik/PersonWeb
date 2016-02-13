using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class PersonRepository : IRepository<Person>
    {
        private UserContext db = new UserContext();

        public PersonRepository()
        {
        }
        UserContext context = new UserContext();


        public void Create(Person item)
        {
            context.Set<Person>().Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Person persons = context.Persons.Find(id);
            if (persons != null)
                context.Persons.Remove(persons);
            context.SaveChanges();
        }

        public Person Get(int id)
        {
            return context.Persons.Find(id);
        }

        public IEnumerable<Person> GetAll()
        {
            IEnumerable<Person> var = context.Persons.ToList();
            return context.Persons.ToList();
        }

        public void Update(Person item)
        {
            if (item.Id == 0)
            {
                context.Persons.Add(item);
                context.SaveChanges();
            }
            else
            {
                foreach (Phone ph in item.Phones)
                {
                    if (ph.Id != 0)
                    {
                        context.Entry<Phone>(ph).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        ph.PersonId = item.Id;
                        context.Phones.Add(ph);
                    }

                }
                context.Entry(item).State = EntityState.Modified;
                //context.Entry(item.Phones).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Person GetbyRegId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
