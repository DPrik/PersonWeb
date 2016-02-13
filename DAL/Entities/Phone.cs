using DAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Phone
    {
        [Key]
        public int Id { set; get; }
        public string Number { get; set; }
        public string Type { get; set; }

        public int PersonId { get; set; }

        [ForeignKey("PersonId")]  
        public virtual Person Person { get; set; }
    }
}
