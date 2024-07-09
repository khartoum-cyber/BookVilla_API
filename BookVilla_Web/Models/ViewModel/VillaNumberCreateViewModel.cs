using BookVilla_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookVilla_Web.Models.ViewModel
{
    public class VillaNumberCreateViewModel
    {
        public VillaNumberCreateViewModel()
        {
            VillaNumber = new VillaNumberDTOcreate();
        }

        public VillaNumberDTOcreate VillaNumber { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}
