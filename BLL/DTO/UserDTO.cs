using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
   public class UserDTO
    {

        public int Id { get; set; }

        public string RegId { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public byte[] Photo { get; set; }


        public virtual List<PersonDTO> Persons { get; set; }


    }
}
