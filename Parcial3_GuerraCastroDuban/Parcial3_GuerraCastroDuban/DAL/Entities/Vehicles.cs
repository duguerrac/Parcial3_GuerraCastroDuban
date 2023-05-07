using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3_GuerraCastroDuban.DAL.Entities
{
    public class Vehicles: Entity
    {
        public Guid ServiceId { get; set; }
        public String Owner { get; set; }
        public String NumberPlate { get; set; }
    }
}
