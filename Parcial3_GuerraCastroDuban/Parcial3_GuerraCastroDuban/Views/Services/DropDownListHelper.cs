using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parcial3_GuerraCastroDuban.DAL;
using Parcial3_GuerraCastroDuban.Helpers;

namespace Parcial3_GuerraCastroDuban.Views.Services
{
    public class DropDownListHelper : IDropDownListHelper
    {
        private readonly DataBaseContext _context;
        public DropDownListHelper(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetDDLServiceAsync()
        {
            List<SelectListItem> listServices = await _context.Services.Select(c => new SelectListItem
                {
                    Text = c.Name, //Col
                    Value = c.Id.ToString(), //Guid                    
                })
                .OrderBy(c => c.Text)
                .ToListAsync();

            listServices.Insert(0, new SelectListItem
            {
                Text = "Selecione un Servicio...",
                Value = Guid.Empty.ToString(), //Cambio el 0 por Guid.Empty ya que debo manejar el mismo tipo de dato en todo el DDL
                Selected = true //Le coloco esta propiedad para que me salga seleccionada por defecto desde la UI
            });

            return listServices;
        }
    }
}
