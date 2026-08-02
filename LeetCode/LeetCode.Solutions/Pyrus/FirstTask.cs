namespace LeetCode.Pyrus;

public class FirstTask
{
    ///<summary>
    ///Реализовать (без использования LINQ) метод, возвращающий массив без дубликатов сохраняющий порядок элементов.
    ///int[] Distinct(int[] src)
    ///[1,2,5,3,3,2] → [1,2,5,3] 
    /// </summary>
    public int[] Distinct(int[] arr)
    {
        var alreadySeen = new HashSet<int>();
        var result = new List<int>();
        foreach (var item in arr)
        {
            if (alreadySeen.Add(item))
                result.Add(item);
        }
        return result.ToArray();
    }
}