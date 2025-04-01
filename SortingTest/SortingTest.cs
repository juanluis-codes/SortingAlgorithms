using Sorting;

namespace SortingTest
{
    public class SortingTest
    {
        private readonly List<int> list;
        private readonly List<int> sortedList;
        public SortingTest()
        {
            list = [2, 3, 1, 4, 5, 67, 22, 14, 33, 56, 78];
            sortedList = [1, 2, 3, 4, 5, 14, 22, 33, 56, 67, 78];
        }

        [Fact]
        public void GivenUnsortedList_WhenBubbleSortIsCalled_ThenListIsSorted()
        {
            List<int> bubbleSortedList = Sorting.Sorting.BubbleSort(list);
            Assert.Equal(sortedList, bubbleSortedList);
        }

        [Fact]
        public void GivenUnsortedList_WhenInsertionSortIsCalled_ThenListIsSorted()
        {
            List<int> insertionSortedList = Sorting.Sorting.BubbleSort(list);
            Assert.Equal(sortedList, insertionSortedList);
        }

        [Fact]
        public void GivenUnsortedList_WhenMergeSortIsCalled_ThenListIsSorted()
        {
            List<int> mergeSortedList = Sorting.Sorting.MergeSort(list);
            Assert.Equal(sortedList, mergeSortedList);
        }
    }
}