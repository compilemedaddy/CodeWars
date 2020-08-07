/* 
Sheldon, Leonard, Penny, Rajesh and Howard are in the queue for a "Double Cola" drink vending machine; there are no other people in the queue. The first one in the queue (Sheldon) buys a can, drinks it and doubles! The resulting two Sheldons go to the end of the queue. Then the next in the queue (Leonard) buys a can, drinks it and gets to the end of the queue as two Leonards, and so on.

For example, Penny drinks the third can of cola and the queue will look like this:

Rajesh, Howard, Sheldon, Sheldon, Leonard, Leonard, Penny, Penny
Write a program that will return the name of the person who will drink the n-th cola.
*/

using System;

public class Line
{
    public static string WhoIsNext(string[] names, long n)
    {
        var arrLeng = names.Length;
        var j = 1;

        while (n > arrLeng)
        {
            n -= arrLeng;
            arrLeng *= 2;
        }

        while (n > arrLeng / names.Length * j)
        {
            j++;
        }

        return names[j - 1];
    }
}
