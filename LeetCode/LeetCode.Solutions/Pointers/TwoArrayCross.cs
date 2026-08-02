namespace LeetCode.Pointers;

/// <summary>
/// Надо найти пересечения 2-х массивов, отсортированных по возрастанию
/// </summary>
public class TwoArrayCross
{
    public int[] SolveMin(int[] arr1, int[] arr2)
    {
        var p1 = 0;
        var p2 = 0;
        
        var result = new List<int>();

        while (p1 < arr1.Length && p2 < arr2.Length)
        {
            if (arr1[p1] == arr2[p2])
            {
                result.Add(arr1[p1]);

                p1++;
                p2++;
            }
            else
            {
                if (arr1[p1] > arr2[p2])
                {
                    p2++;
                }
                else
                {
                    p1++;
                }
            }
        }

        return result.ToArray();
    }

    public int[] SolveIf(int[] arr1, int[] arr2)
    {
        var p1 = 0;
        var p2 = 0;
        
        var result = new List<int>();

        while (p1 < arr1.Length && p2 < arr2.Length)
        {
            if (arr1[p1] == arr2[p2])
            {
                result.Add(arr1[p1]);
                p1++;
                p2++;
            }
            else
            {
                int min = int.Min(arr1[p1], arr2[p2]);
                if (arr1[p1] == min)
                {
                    p1++;
                }

                if (arr2[p2] == min)
                {
                    p2++;
                }
            }
        }
        
        return result.ToArray();
    }
}