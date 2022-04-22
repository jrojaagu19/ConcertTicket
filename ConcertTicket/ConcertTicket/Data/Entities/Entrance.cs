﻿using System.ComponentModel.DataAnnotations;

namespace ConcertTicket.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe de tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Description { get; set; }

        public ICollection<Entrance> Entrances { get; set; }
    }
}
