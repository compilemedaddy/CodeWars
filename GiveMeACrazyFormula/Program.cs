/* Sum all digits of n with the following rules:

If there isn't a middle digit and n > 9: remove the last digit;
If the middle digit is odd: reduce it instead of sum;
If both the middle digit and the last digit aren't odd: reduce the last digit instead of sum;
If the middle digit isn't odd but the last digit is: sum the first digit squared instead of regular sum;
This must be done until there are only 1 digit(negative number should use abs).

Example:

Input => Result

5 => 5

214 => 2-1+4 = 5

224 => 2+2-4 = 0

2224 => 222 => 2+2-2 = 2

2234 => 223 => 2²+2+3 = 9

126 => 1+2-6 = -3 => 3 */

using System;
namespace CrazyFormula
{

    public class Crazy
    {
        public int CrazyFormula(long n)
        {
            string nString = n.ToString();
            int result;
            bool middleIsOdd;
            bool middleLastEven;
            bool midEvenLastOdd;
            do
            {

                middleIsOdd = false;
                middleLastEven = false;
                midEvenLastOdd = false;
                result = 0;

                if (nString.Length % 2 == 0 && n > 9)
                {
                    nString = nString.Substring(0, nString.Length - 1);

                }
                if (nString.Length == 1)
                {
                    return nString[0] - 48;
                }
                if (nString[nString.Length / 2] % 2 != 0)
                {
                    middleIsOdd = true;
                }
                if (nString[nString.Length / 2] % 2 == 0 && nString[nString.Length - 1] % 2 == 0)
                {
                    middleLastEven = true;
                }

                if (nString[nString.Length / 2] % 2 == 0 && nString[nString.Length - 1] % 2 != 0)
                {
                    midEvenLastOdd = true;
                }

                for (int i = 0; i < nString.Length; i++)
                {
                    if (midEvenLastOdd && i == 0)
                    {
                        result = (int)Math.Pow(nString[0] - 48, 2);
                    }
                    else if (middleIsOdd && i == nString.Length / 2)
                    {
                        result -= nString[nString.Length / 2] - 48;
                    }
                    else if (middleLastEven && i == nString.Length - 1)
                    {
                        result -= nString[nString.Length - 1] - 48;
                    }
                    else
                        result += nString[i] - 48;
                }
                nString = result.ToString();
            }
            while (result > 9);

            if (result < 0)
                result = Math.Abs(result);
            return result;
        }
    }
}

