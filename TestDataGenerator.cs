namespace CPSC_6109_Coursework;

public class TestDataGenerator
{
    private Random random = new();

    public int[] Generate(long size)
    {
        int[] arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = random.Next();
        }
        
        return arr;
    }
}