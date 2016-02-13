
using System.Collections.Generic;

namespace persons_with_adress.Models
{
    public class PersoneViewModel
    {
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public int UserId { get; set; }

        public UserViewModel User { get; set; }

        public  List<PhoneViewModel> Phones { get; set; }
        public  List<AddressViewModel> Addresses { get; set; }

       
    }
}