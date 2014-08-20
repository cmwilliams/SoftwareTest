using System.ComponentModel.DataAnnotations;

namespace SoftwareTest.Models.ViewModels
{
    public class LinkedListFormViewModel
    {
        [Required]
        [Display(Name = "List Index to View")]
        [Range(1, int.MaxValue)]
        public int Index { get; set; }
    }
}