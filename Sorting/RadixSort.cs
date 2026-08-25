namespace CPSC_6109_Coursework.Sorting;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description:
 * Sources: Algorithm steps from W3Schools.
 * Last Modified: August 25, 2026
 */
public class RadixSort
{
    public double[] Sort(double[] unsortedArr)
    {
        Stack<double> unsortedStack = new Stack<double>(unsortedArr);
        double[] sortedArr = new double[unsortedArr.Length];
        
        double max = unsortedArr.Max();
        int radix = 1;

        while (Math.Floor(max / radix) > 0)
        {
            while (unsortedArr.Length > 0)
            {
                var value = unsortedStack.Pop();
                var radixIndex = (int)Math.Floor(value / radix) % 10;

                sortedArr[radixIndex] = value;
            }
            
            // for () {}
        }

        return sortedArr;
    }
}