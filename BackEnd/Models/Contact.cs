using System.ComponentModel.DataAnnotations;

namespace QueroServicos.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Whatsapp { get; set; }

        [StringLength(50)]
        public string Telegram { get; set; }

        [StringLength(50)]
        public string Facebook { get; set; }

        [StringLength(50)]
        public string Instagram { get; set; }
    }
}
