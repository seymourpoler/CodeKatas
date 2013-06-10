
namespace Code
{
    static class Extensions
    {
        public static bool IsPrime(this int number)
        {
            bool result = true;

            int cont = 1;
            while((result) && (cont<number))
            {
                if((number % cont == 0) && (cont != 1))
                {
                    result = false;
                }
                cont++;
            }

            return result;
        }

        public static bool IsPositive(this int number)
        {
            bool result = true;

            if(number < 0)
            {
                result = false;
            }

            return result;
        }
    }
}
