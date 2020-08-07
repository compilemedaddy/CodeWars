/* 
Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

The binary number returned should be a string.
*/

using System;

public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        return Convert.ToString(a + b, 2);
    }
}