using System.Linq;
using System.Collections.Generic;

namespace MaxMin
{
    public class MaxMinManager
    {
        public int Max(List<int> data )
        {
            if (!data.Any())
            {
                return 0;
            }
            var result = int.MinValue;
            data.ForEach(number =>
                {
                    if (number > result)
                    {
                        result = number;
                    }
                });
            return result;
        }

        public int Min(List<int> data)
        {
            if (!data.Any())
            {
                return 0;
            }
            var result = int.MaxValue;
            data.ForEach(number =>
            {
                if (number < result)
                {
                    result = number;
                }
            });
            return result;
        }
    }
}
