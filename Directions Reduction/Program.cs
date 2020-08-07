/*
Write a function dirReduc which will take an array of strings and returns an array of strings with the needless directions removed (W<->E or S<->N side by side).

The Haskell version takes a list of directions with data Direction = North | East | West | South.
The Clojure version returns nil when the path is reduced to nothing.
The Rust version takes a slice of enum Direction {NORTH, SOUTH, EAST, WEST}.
*/

using System;
using System.Linq;
public class DirReduction
{

    public static string[] dirReduc(String[] arr)
    {

        var arrLength = arr.Length;
        for (var i = arr.Length - 1; i > 0; i--)
        {

            var move = arr[i];
            switch (move)
            {

                case "NORTH":
                    if (arr[i - 1] == "SOUTH")
                    {
                        arr = arr.Where((val, idx) => idx != i).ToArray();
                        arr = arr.Where((val, idx) => idx != i - 1).ToArray();
                        i = arr.Length;
                    }
                    break;
                case "SOUTH":
                    if (arr[i - 1] == "NORTH")
                    {
                        arr = arr.Where((val, idx) => idx != i).ToArray();
                        arr = arr.Where((val, idx) => idx != i - 1).ToArray();
                        i = arr.Length;
                    }
                    break;
                case "EAST":
                    if (arr[i - 1] == "WEST")
                    {
                        arr = arr.Where((val, idx) => idx != i).ToArray();
                        arr = arr.Where((val, idx) => idx != i - 1).ToArray();
                        i = arr.Length;
                    }
                    break;
                case "WEST":
                    if (arr[i - 1] == "EAST")
                    {
                        arr = arr.Where((val, idx) => idx != i).ToArray();
                        arr = arr.Where((val, idx) => idx != i - 1).ToArray();
                        i = arr.Length;
                    }
                    break;
            }
        }
        return arr;
    }
}