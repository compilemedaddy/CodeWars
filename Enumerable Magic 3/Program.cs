/*
 * 
 Create a method that accepts a list and an item, and returns true if the item belongs to the list, otherwise false.

*/
public class Kata
{
    public static bool Include(int[] arr, int item)
    {
        foreach (int i in arr)
        {
            if (i.Equals(item))
            {
                return true;
            }
        }
        return false;
    }
}