using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3_GuerraCastroDuban.DAL.Entities
{
    public class Vehicle: Entity
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Propietario")]
        public String Owner { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Placa del vehiculo")]
        public String NumberPlate { get; set; }

        public Service Service { get; set; }

        public ICollection<VehicleDetails> VehicleDetails { get; set; }
    }
}
