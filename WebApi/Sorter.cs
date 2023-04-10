namespace WebApi
{
    public class Sorter
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
