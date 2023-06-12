using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroServicos.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Column("name_pt")]
        public string NamePt { get; set; }

        public string Acronym { get; set; }
        public int? Bacen { get; set; }

        public ICollection<State> State { get; } = new List<State>();
    }
}
