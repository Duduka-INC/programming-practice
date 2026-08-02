namespace LeetCode.Pyrus;

public static class SecondTask
{
    public static IEnumerable<T> FilterLast<T>(this IEnumerable<T> source, int n)
    {
        if (source == null)
        {
            throw new Exception("Source is null");
        }

        if (n < 0)
        {
            throw new Exception("Number of elements negative");
        }

        if (n == 0)
        {
            foreach(var item in source)
                yield return item;
            
            yield break;
        }
        
        var buffer = new Queue<T>(n + 1);
        
        foreach (var item in source)
        {
            buffer.Enqueue(item);
            Console.Write(item);
            
            if (buffer.Count > n)
                yield return buffer.Dequeue();
        }
    }

    public static void Test()
    {
        Enumerable.Range(1, 100).FilterLast(2).First();
    }
}

