using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace QueroServicos.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string UF { get; set; }

        public int? IBGE { get; set; }

        public string DDD { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; } = null!;
    }
}
