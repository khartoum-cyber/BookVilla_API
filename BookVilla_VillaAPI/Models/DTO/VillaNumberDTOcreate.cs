using System.ComponentModel.DataAnnotations;

namespace BookVilla_VillaAPI.Models.DTO
{
    public class VillaNumberDTOcreate
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }

        public string SpecialDetails { get; set; }
    }
}
