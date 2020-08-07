/*
You are required to create a simple calculator that returns the result of addition, subtraction, multiplication or division of two numbers.

Your function will accept three arguments:
The first and second argument should be numbers.
The third argument should represent a sign indicating the operation to perform on these two numbers.

If the sign is not a valid sign, throw an ArgumentException.
*/

using System;

public class Kata
{
    public static double Calculator(double a, double b, char op)
    {
        if (op == null)
        {
            throw new ArgumentNullException();
        }
        switch (op)
        {
            case '+':
                return a + b;

            case '-':
                return a - b;

            case '*':
                return a * b;

            case '/':
                return a / b;

            default:

                throw new ArgumentException();
        }

    }
}