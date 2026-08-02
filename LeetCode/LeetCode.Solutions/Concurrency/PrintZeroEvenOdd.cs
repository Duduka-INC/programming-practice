namespace LeetCode.Concurrency;

public class ZeroEvenOdd {
    private int n;

    private SemaphoreSlim _zeroGate;
    private SemaphoreSlim _evenGate;
    private SemaphoreSlim _oddGate;
    
    public ZeroEvenOdd(int n) {
        this.n = n;
        
        _zeroGate = new SemaphoreSlim(1, 1);
        _evenGate = new SemaphoreSlim(0, 1);
        _oddGate = new SemaphoreSlim(0, 1);
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Zero(Action<int> printNumber) {
        for (int i = 0; i < n; i++)
        {
            _zeroGate.Wait();
            
            printNumber(0);
            if (i % 2 == 0)
            {
                _oddGate.Release();
            }
            else
            {
                _evenGate.Release();
            }
        }
    }

    public void Even(Action<int> printNumber) {
        for (int i = 2; i <= n; i = i + 2)
        {
            _evenGate.Wait();
            printNumber(i);
            _zeroGate.Release();
        }
    }

    public void Odd(Action<int> printNumber) {
        for (int i = 1; i <= n; i = i + 2)
        {
            _oddGate.Wait();
            printNumber(i);
            _zeroGate.Release();
        }
    }
}
