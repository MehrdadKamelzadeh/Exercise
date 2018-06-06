namespace Algorithms
{
    public class MyQuickSort
    {

        public void DoQuickSort(int[] arr, int left, int right)
        {
            var pivot = Partition(arr, left, right);

            if (left < right)
            {
                if (pivot > 1)
                {
                    DoQuickSort(arr, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    DoQuickSort(arr, pivot + 1, right);
                }
            }

        }

        private int Partition(int[] arr, int left, int right)
        {
            var pivot = arr[left];

            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left == right)
                {
                    return right;
                }
                if (left < right)
                {
                    Swap(arr, left, right);
                }

            }
        }

        private void Swap(int[] arr, int left, int right)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
