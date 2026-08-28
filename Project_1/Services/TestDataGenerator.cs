namespace CPSC_6109_Coursework;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description: Generate method creates an integer array of predetermined size and populates it with random values
 *              of the same seed within the range 0 to 100,000.
 * Last Modified: August 28, 2026
 */
public class TestDataGenerator
{
    // Ensure all values generated with same seed. 
    private Random random = new(888);

    // Method receives integer parameter for array size.
    public int[] Generate(int size)
    {
        int[] arr = new int[size];

        // Iterate each index and populate with random integer in range.
        for (int i = 0; i < size; ++i)
        {
            arr[i] = random.Next(0, 100000);
        }
        
        return arr;
    }
}