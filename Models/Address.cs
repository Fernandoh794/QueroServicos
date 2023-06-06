using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroServicos.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }

        [ForeignKey("Neighborhood")]
        public int NeighborhoodId { get; set; }

        public virtual Neighborhood Neighborhood { get; set; }
    }
}