namespace LeetCode.Pointers;

public class SameNumber
{
    public int Solve(int[] arr1, int[] arr2, int[] arr3)
    {
        var p1 = 0;
        var p2 = 0;
        var p3 = 0;
        
        while(p1 < arr1.Length && p2 < arr2.Length && p3 < arr3.Length)
        {
            if (arr1[p1] == arr2[p2] && arr2[p2] == arr3[p3])
            {
                return arr1[p1];
            }
            
            int min = Math.Min(arr1[p1], Math.Min(arr2[p2], arr3[p3]));
            
            if (arr1[p1] == min)
            {
                p1++;
            }

            if (arr2[p2] == min)
            {
                p2++;
            }

            if (arr3[p3] == min)
            {
                p3++;
            }
        }
        
        return -1;
    }
}