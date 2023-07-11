using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroServicos.Models
{
    public class UserFeedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("UserContratante")]
        public int UserIdContratante { get; set; }

        [Required]
        public int Avaliacao { get; set; }

        public string Comentario { get; set; }

    }
}
