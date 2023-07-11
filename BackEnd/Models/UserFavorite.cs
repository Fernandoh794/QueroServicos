﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QueroServicos.Models
{
    public class UserFavorite
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("UserFavoritado")]
        public int UserFavoritadoId { get; set; }
    }
}
