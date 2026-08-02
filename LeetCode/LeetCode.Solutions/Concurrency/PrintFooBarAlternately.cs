namespace LeetCode.Concurrency;

public class FooBar {
    private int n;
    private SemaphoreSlim _fooGate;
    private SemaphoreSlim _barGate;
    
    public FooBar(int n) {
        _fooGate = new SemaphoreSlim(0, 1);
        _barGate = new SemaphoreSlim(1, 1);
        this.n = n;
    }

    public void Foo(Action printFoo) {
        
        for (int i = 0; i < n; i++) {
            _barGate.Wait();
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            _fooGate.Release();
            
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
            _fooGate.Wait();
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();
            _barGate.Release();
        }
    }
}