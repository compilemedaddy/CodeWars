/*
Who likes keywords? Nobody likes keywords! So why use them?

You know what keyword I use too much? if!

We should create a function called _if which takes 3 arguments: a truthy/falsey value, and 2 functions.

Similar to the if/else statement, when the first argument is truthy, you should call the function #1, otherwise call the function #2.
*/

using System;

public class Kata
{
    public static void If(bool condition, Action func1, Action func2)
    {
        if (condition)
        {
            func1();
        }
        else
        {
            func2();
        }
    }
}