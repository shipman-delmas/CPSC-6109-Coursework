namespace CPSC_6109_Coursework;

public class TestDataGenerator
{
    private Random random = new();

    public int[] Generate(int size)
    {
        int[] arr = new int[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = random.Next();
        }
        
        return arr;
    }
}