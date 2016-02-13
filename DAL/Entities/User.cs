using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string RegId { set; get; }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    
        public byte[] Photo { get; set; }
        public virtual List<Person> Persons { get; set; }

        
    }
}
