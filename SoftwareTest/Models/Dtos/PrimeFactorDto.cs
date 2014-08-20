using System.Collections.Generic;

namespace SoftwareTest.Models.Dtos
{
    public class PrimeFactorDto
    {
        public int Integer { get; set; }
        public List<int> PrimeFactors { get; set; } 
    }
}