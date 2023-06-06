using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QueroServicos.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }

        public virtual State State { get; set; }
    }
}
