namespace Prime.Utility.Tests
{
    public class Tests
    {
        [TestCase(-1,false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(9, false)]
        [TestCase(16, false)]
        [TestCase(25, false)]
        [TestCase(100, false)]
        public void IsPrimeTest_判斷是否為質數(int N, bool expected)
        {
            bool actual = IsPrimeUtility.IsPrime(N);
            
            Assert.AreEqual(expected, actual);
        }
    }
}