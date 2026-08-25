namespace CPSC_6109_Coursework;

public class TestDataGenerator
{
    private Random random = new();

    public double[] Generate(int size)
    {
        double[] arr = new double[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = random.Next();
        }
        
        return arr;
    }
}