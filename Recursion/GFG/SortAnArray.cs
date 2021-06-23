namespace Recursion.GFG
{
    class SortAnArray
    {
        internal void SortArray(ref int[] arr, int index)
        {
            if (index == 0)
                return;
            SortArray(ref arr, index - 1);
            Insert(ref arr, index, arr[index]);
        }

        void Insert(ref int[] arr, int index, int currentValue)
        {
            if (index == 0 || arr[index-1] < currentValue)
            {
                arr[index] = currentValue;
            }
            else
            {
                arr[index] = arr[index - 1];
                Insert(ref arr, index - 1, currentValue);
            }
        }

    }
}
