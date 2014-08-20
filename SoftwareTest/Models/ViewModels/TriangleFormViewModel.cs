using System.ComponentModel.DataAnnotations;

namespace SoftwareTest.Models.ViewModels
{
    public class TriangleFormViewModel
    {
        [Required]
        [Display(Name = "Side A")]
        [Range(1, int.MaxValue)]
        public int SideA { get; set; }

        [Required]
        [Display(Name = "Side B")]
        [Range(1, int.MaxValue)]
        public int SideB { get; set; }

        [Required]
        [Display(Name = "Side C")]
        [Range(1, int.MaxValue)]
        public int SideC { get; set; }


    }
}