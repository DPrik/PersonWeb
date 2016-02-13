using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
  public  class PhoneDTO
    {
        public int Id { set; get; }
        public string Number { get; set; }
        public string Type { get; set; }

        public int PersonId { get; set; }
        public PersonDTO Person { get; set; }
    }
}
