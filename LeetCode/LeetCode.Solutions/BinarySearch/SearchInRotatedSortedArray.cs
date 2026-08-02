namespace LeetCode.BinarySearch;

public class SearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
            return -1;

        int pivot = FindPivot(nums);

        // массив не сдвинут
        if (pivot == 0)
            return BinarySearch(nums, 0, nums.Length - 1, target);

        if (target >= nums[0] && target <= nums[pivot - 1])
            return BinarySearch(nums, 0, pivot - 1, target);

        return BinarySearch(nums, pivot, nums.Length - 1, target);
    }

    private int FindPivot(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int last = nums[nums.Length - 1];

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] <= last) // good
                right = mid;
            else                   // bad
                left = mid + 1;
        }

        return left;
    }

    private int BinarySearch(int[] nums, int left, int right, int target)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}