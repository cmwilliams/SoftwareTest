using System;
using System.Collections.Generic;

namespace SoftwareTest.Helpers
{
    public static class PrimeFactorHelper
    {
        public static List<int> GetPrimeFactors(string file)
        {
            var result = new List<int>();
            try
            {
                string line;
                var textFile = new System.IO.StreamReader(file);
                while ((line = textFile.ReadLine()) != null)
                {
                    int item;
                    if (int.TryParse(line, out item))
                    {
                        result.Add(item);
                    }
                }
                textFile.Close();
            }
            catch (Exception)
            {
                //Add Logging Function here
                return result;
            }

            return result;
        }
    }
}