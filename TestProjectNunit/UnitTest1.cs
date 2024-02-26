using OurNunitLib;

namespace TestProjectNunit
{
    [TestFixture]
    public class Tests
    {
        Calc calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calc();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test] 
        public void AddTest()
        {
            int n1 = 5;
            int n2 = 10;
            int r = 15;
            Assert.AreEqual(r, calc.Add(n1, n2));
        }
        [Test]
        public void AvgTest()
        {
            int n1 = 50;
            int n2 = 10;
            int r = 30;
            Assert.AreEqual(r, calc.Avg(n1, n2));
        }
        [Test]
        public void DifTest()
        {
            int n1 = 5;
            int n2 = 10;
            int r = -5;
            Assert.AreEqual(r, calc.Diff(n1, n2));
        }
        [Test]
        public void MulTest()
        {
            int n1 = 5;
            int n2 = 10;
            int r = 50;
            Assert.AreEqual(r, calc.Multi(n1, n2));
        }
    }
}