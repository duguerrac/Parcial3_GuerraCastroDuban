using System.ComponentModel.DataAnnotations;

namespace Parcial3_GuerraCastroDuban.DAL.Entities
{
    public class VehicleDetails: Entity
    {
        [Required]
        [Display(Name = "Fecha de creacion")]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Fecha de entrega")]
        public DateTime? DeliveryDate { get; set; }
        public Vehicle vehicle { get; set; }
    }
}
