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

        public string Sigla { get; set; }

    }
}
