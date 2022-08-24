using ConsoleApp7new;
namespace TestProject1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator C = new Calculator();
            int result = C.Add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}