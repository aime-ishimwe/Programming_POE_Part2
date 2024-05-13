namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] number = {1,2,3,4,5};
            double result = calculateTotal(number);
            //Assert
            Assert.AreEqual(15, result); //expected sum is 1+2+3+4+5=15
        }

        //method to calculate calories
        public double calculateTotal(double[] calories)
        {
            double result = 0;
            for (int i = 0; i < calories.Length; i++)
            {
                result += calories[i];
            }
            return result;

        }
    }
    
}