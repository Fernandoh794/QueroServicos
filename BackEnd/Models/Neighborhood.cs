using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QueroServicos.Models
{
    public class Neighborhood
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        public virtual City City { get; set; }
    }
}
