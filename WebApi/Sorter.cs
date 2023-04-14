namespace WebApi
{
    public class Sorter
    {
        public static void Sort(int[] array,bool isAsc)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (isAsc && array[i] > array[j])
                        Change(array, i, j);
                    else if (!isAsc && array[i] < array[j])
                        Change(array,i,j);
                }
            }
        }
        private static void Change(int[] array,int i,int j)
        {
            array[i] += array[j];
            array[j] = array[i] - array[j];
            array[i] = array[i] - array[j];
        }
    }
}
