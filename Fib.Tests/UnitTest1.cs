namespace Fib.Tests;
using FibPro;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
       ulong f1 = Fib.FibIter(1);
       ulong a = 0;
       Assert.AreEqual(f1, a);
    }
    [TestMethod]
    public void TestMethod2()
    {
       ulong f2 = Fib.FibIter(2);
       ulong a = 1;
       Assert.AreEqual(f2, a);
    }
    [TestMethod]
    public void TestMethod3()
    {
       ulong f3 = Fib.FibIter(3);
       ulong a = 1;
       Assert.AreEqual(f3, a);
    }
    [TestMethod]
    public void TestMethod8()
    {
       ulong f8 = Fib.FibIter(8);
       ulong a = 13;
       Assert.AreEqual(f8, a);
    }
}