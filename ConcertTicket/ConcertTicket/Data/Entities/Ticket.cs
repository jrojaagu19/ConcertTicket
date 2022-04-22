using System.ComponentModel.DataAnnotations;

namespace ConcertTicket.Data.Entities
{
    public class Ticket
    {

        public int Id { get; set; }

        public Boolean WasUsed { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {1} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo (0) documento es obligatorio")]

        public String Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {2} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo (0) ciudad es obligatorio")]
        public String Name { get; set; }

        public Entrance Entrance { get; set; }

        [Display(Name = "Hora de entrada al concierto ")]
        public DateTime Date { get; set; }


    }
}
