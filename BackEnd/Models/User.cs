using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroServicos.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Type { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(14, MinimumLength = 11)]
        public string CpfCnpj { get; set; }


        [Required]
        [RegularExpression("^[1-2]$")]
        public string TipoPessoa { get; set; }



        [Required]
        [MaxLength(60)]
        public string Email { get; set; }

        [Required]
        [MaxLength(30)]
        public string Password { get; set; }

        [StringLength(13)]
        public string Number { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
