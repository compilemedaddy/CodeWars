/*
You have an array of numbers.
Your task is to sort ascending odd numbers but even numbers must be on their places.

Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.
*/

using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static int[] SortArray(int[] array)
    {
        List<int> tempOdd = new List<int>();
        List<int> temp = new List<int>();
        array.ToList().ForEach(x =>
        {

            if (x % 2 != 0)
            {
                tempOdd.Add(x);
                temp.Add(int.MaxValue);
            }
            else temp.Add(x);
        });
        int iCount = 0;
        tempOdd.Sort();
        tempOdd.ForEach(x => Console.Write(x));
        Console.WriteLine("");
        temp.Select((v, i) => new { value = v, index = i }).Where(x => true).ToList().ForEach(x =>
        {
            if (x.value == int.MaxValue)
            {
                temp[x.index] = tempOdd[iCount];
                iCount++;
            }
        });
        return temp.ToArray();
    }
}