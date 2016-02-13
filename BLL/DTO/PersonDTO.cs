using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class PersonDTO
    {
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public int UserId { get; set; }

        public virtual List<PhoneDTO> Phones { get; set; }
        public virtual List<AddressDTO> Addresses { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
