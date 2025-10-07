using WhiteLagon.Domain.Entities;

namespace WhiteLagon.web.ViewModel
{
    public class HomeVM
    {
        public IEnumerable<Villa> VillaList { get; set; }
        public DateOnly? CheckInDate { get; set; }
        public DateOnly? CheckOutDate { get; set; }
        public int Nights { get; set; }

    }
}
