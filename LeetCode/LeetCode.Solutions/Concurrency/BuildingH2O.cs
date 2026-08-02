namespace LeetCode.Concurrency;

public class H2O
{
    private SemaphoreSlim _hydrogenGate =  new SemaphoreSlim(2, 2);
    private SemaphoreSlim _oxygenGate = new SemaphoreSlim(1, 1);
    private Barrier _barrier;
    public H2O()
    {
        _barrier = new Barrier(3, _ =>
        {
            _hydrogenGate.Release(2);
            _oxygenGate.Release(1);
        });
    }

    public void Hydrogen(Action releaseHydrogen) {
        _hydrogenGate.Wait();
        releaseHydrogen();
        var thread = Thread.CurrentThread;
        Console.WriteLine($"thread {thread.ManagedThreadId} wrote H. O: {_oxygenGate.CurrentCount}; H: {_hydrogenGate.CurrentCount}; Barrier: {_barrier.CurrentPhaseNumber}");
        _barrier.SignalAndWait();
    }

    public void Oxygen(Action releaseOxygen) {
        _oxygenGate.Wait();
        releaseOxygen();
        var thread = Thread.CurrentThread;
        Console.WriteLine($"thread {thread.ManagedThreadId} wrote H. O: {_oxygenGate.CurrentCount}; H: {_hydrogenGate.CurrentCount}; Barrier: {_barrier.CurrentPhaseNumber}");
        _barrier.SignalAndWait();
    }
}

public class H2Onew
{
    private SemaphoreSlim _hydrogenGate =  new SemaphoreSlim(2, 2);
    private SemaphoreSlim _oxygenGate = new SemaphoreSlim(1, 1);
    private object _lock = new object();
    private int _counter = 0;
    private int _generation = 0;

    public H2Onew ()
    {
    }

    public void Hydrogen(Action releaseHydrogen) {
        _hydrogenGate.Wait();
        releaseHydrogen();
        CountAndWait();
    }

    public void Oxygen(Action releaseOxygen)
    {
        _oxygenGate.Wait();
        releaseOxygen();
        CountAndWait();
    }

    private void CountAndWait()
    {
        lock (_lock)
        {
            int myGeneration = _generation;
            _counter++;
        
            if (_counter == 3)
            {
                _generation++;
                _counter = 0;
                _oxygenGate.Release();
                _hydrogenGate.Release(2);
                
                Monitor.PulseAll(_lock);
            }
            else
            {
                while (myGeneration == _generation)
                {
                    Monitor.Wait(_lock);
                }
            }
        }
    }

}