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

        public static List<int> MergeSort(List<int> list)
        {
            if(list.Count <= 1)
            {
                return list;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count / 2 > i)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            return result;
        }
    }
}
