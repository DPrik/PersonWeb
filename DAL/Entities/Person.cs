using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAL.Entities
{
    public class Person
    {
        [Key]
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public virtual List<Phone> Phones { get; set; }
        public virtual List<Address> Addresses { get; set; }


        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

       
    }
}