using System.Globalization;

namespace Sorting
{
    public class Sorting
    {
        public static List<int> BubbleSort(List<int> list)
        {

            int temp;

            for(int i = list.Count - 1; i >= 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (list[j-1] > list[j])
                    {
                        temp = list[j-1];
                        list[j-1] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list;
        }

        public static List<int> InsertionSort(List<int> list)
        {
            int key, j;
            for (int i = 2; i < list.Count; i++) 
            {
                key = list[i];
                j = i - 1;

                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }

                list[j + 1] = key;
            }

            return list;
        }
    }
}
