using System.ComponentModel.DataAnnotations;

namespace ConcertTicket.Models
{
    public class TicketViewModel
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

        public int EntranceId { get; set; }

        public DateTime Date { get; set; }
    }
}
