using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using WhiteLagon.Domain.Entities;

namespace WhiteLagon.web.ViewModel
{
    public class AmenityVM
    {
        public Amenity Amenity { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? VillaList { get; set; }
    }
}
