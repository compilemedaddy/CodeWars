/* 
 Write a function called checkCoupon which verifies that a coupon code is valid and not expired.

A coupon is no more valid on the day AFTER the expiration date. All dates will be passed as strings in this format: "MONTH DATE, YEAR".

*/

using System;

public static class Kata
{
    public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
    {
        var parsedCurr = DateTime.Parse(currentDate);
        var parsedExpi = DateTime.Parse(expirationDate);

        if (enteredCode == correctCode && parsedCurr <= parsedExpi)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}