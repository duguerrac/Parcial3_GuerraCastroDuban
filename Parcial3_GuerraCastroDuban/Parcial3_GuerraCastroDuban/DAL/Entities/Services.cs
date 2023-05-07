namespace Parcial3_GuerraCastroDuban.DAL.Entities;
using System.ComponentModel.DataAnnotations;

    public class Services: Entity
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public int Price { get; set; }
    }

