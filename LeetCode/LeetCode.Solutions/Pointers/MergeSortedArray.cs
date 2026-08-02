namespace LeetCode.Pointers;

public class MergeSortedArray
{
    public int[] SolveMyOwn(int[] nums1, int m, int[] nums2,  int n)
    {
        var p1 = 0;
        var p2 = 0;

        var result = new int[m + n];
        var idx = 0;

        while (p1 < m && p2 < n)
        {
            if (nums1[p1] == nums2[p2])
            {
                result[idx] = nums1[p1];
                idx++;
                result[idx] = nums2[p2];
                idx++;
                p1++;
                p2++;
            }
            else if (nums1[p1] < nums2[p2])
            {
                result[idx] = nums1[p1];
                idx++;
                p1++;
            }
            else
            {
                result[idx] = nums2[p2];
                idx++;
                p2++;
            }
        }
        
        while (p1 < m)
            result[idx++] = nums1[p1++];

        while (p2 < n)
            result[idx++] = nums2[p2++];
        
        return result;
    }
    
    public void Solve(int[] nums1, int m, int[] nums2,  int n)
    {
        
    }
}