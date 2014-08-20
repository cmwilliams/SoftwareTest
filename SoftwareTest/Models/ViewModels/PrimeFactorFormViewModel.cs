using System.Collections.Generic;
using System.Web;
using SoftwareTest.Models.Dtos;

namespace SoftwareTest.Models.ViewModels
{
    public class PrimeFactorFormViewModel
    {
        public HttpPostedFileBase TextFile { get; set; }
        public List<PrimeFactorDto> PrimeFactors { get; set; }

        public PrimeFactorFormViewModel()
        {
            PrimeFactors = new List<PrimeFactorDto>();
        }
    }
}