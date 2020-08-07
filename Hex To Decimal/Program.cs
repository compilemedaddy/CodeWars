/*
 Complete the function which converts hex number (given as a string) to a decimal number.
 */

using System;
using System.Linq;
public class Kata
{
    public static int HexToDec(string hexString)
    {
        int decValue = 0;
        if (hexString.ToLower().Contains('-'))
        {
            char[] arr = { '-' };
            hexString = hexString.Trim(arr);
            decValue = Convert.ToInt32(hexString, 16);
            decValue -= decValue * 2;
        }
        else
            decValue = Convert.ToInt32(hexString, 16);
        return decValue;
    }
}