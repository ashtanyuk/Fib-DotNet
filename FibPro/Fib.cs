namespace FibPro;
public class Fib
{
    public static ulong FibIter(int n) 
    {
        ulong a = 0, b = 1, sum;
        while( n > 1 ) 
        {
            sum = a + b;
            a = b;
            b = sum;
            n--;
        }
        return a;
    }
}
