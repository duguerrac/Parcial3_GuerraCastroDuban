using Microsoft.AspNetCore.Mvc.Rendering;

namespace Parcial3_GuerraCastroDuban.Helpers
{
    public interface IDropDownListHelper
    {
        Task<IEnumerable<SelectListItem>> GetDDLServiceAsync();

    }
}
