

using System.Collections.Generic;

namespace Code
{
    public class PrimeFactors
    {
        private int _number;
        public PrimeFactors(int number)
        {
            _number = number;
        }


        public List<int> GeneratePrimeFactors()
        {
            List<int> result = new List<int>();
            
            if(_number.IsPositive())
            {
                for(int cont=1; cont<_number; cont++)
                {
                    if(cont.IsPrime())
                    {
                        result.Add(cont);
                    }
                }
            }
            return result;
        }
    }
}
