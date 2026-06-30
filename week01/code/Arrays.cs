using System.Globalization;
using System.Security.Cryptography;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>




    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //plan:
        // Create a new array called result with the size given by length
        // Use a for loop to go each index of the array
        // Since arrays start index 0, use (i+1)*number to calculate the correct multiple
        // Store each multiple in the correct position of the result array
        // Return the completed array
        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = (i + 1) * number;
        }

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>

    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Plan:
        //Create a new empty list called result.
        //Find the starting position of the elements that need to move to the front. This position is data.Count - amount.
        //Starting from that position, copy each element from data to result until the end of the list.
        //Then go back to the beginnig of data to result until the position before data.Count - amount.
        //At this point, rsult has the rotated order.
        //Copy each element from result back into data.
        List<int> result = new List<int>();
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            result.Add(data[i]);
        }
        for (int i = 0; i < data.Count - amount; i++)
        {
            result.Add(data[i]);
        }
        for (int j = 0; j < data.Count; j++)
        {
            data[j] = result[j];
        }

    }
}
