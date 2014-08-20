using System;
using System.Collections.Generic;
using System.IO;
using SoftwareTest.Models.Dtos;

namespace SoftwareTest.Helpers
{
    public static class PrimeFactorHelper
    {
        public static List<PrimeFactorDto> GetPrimeFactors(string file)
        {
            var results = new List<PrimeFactorDto>();
            try
            {
                var lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    int number;
                    if (int.TryParse(line, out number))
                    {
                        results.Add(new PrimeFactorDto
                        {
                            Integer = number,
                            PrimeFactors = GetFactors(number)
                        });
                    }
                }
            }
            catch (Exception)
            {
                //Add Logging Function here
                return results;
            }

            return results;
        }

        public static List<int> GetFactors(int number)
        {
            int factor;
            var results = new List<int>();
            for (factor = 2; number > 1; factor++)
                if (number % factor == 0)
                {
                    var x = 0;
                    while (number % factor == 0)
                    {
                        number /= factor;
                        x++;
                    }
                    for (var i = 0; i < x; i++)
                    {
                        results.Add(factor);
                    }
                }
            return results;
        }


       
    }
}