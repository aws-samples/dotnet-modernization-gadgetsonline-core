namespace GadgetOnlineTests
{
    public class GadgetOnlineTest
    {
        [Fact]
        public void MinTest()
        {
            int num1 = 1;
            int num2 = 2;

            var min = Math.Min(num1, num2);

            Assert.Equal(num1, min);

        }

        [Fact]
        public void MaxTest()
        {
            int num1 = 1;
            int num2 = 2;

            var min = Math.Max(num1, num2);

            Assert.Equal(num2, min);

        }


        [Fact]
        public void SqrtTest()
        {
            int num1 = 144;

            var sqrt = Math.Sqrt(num1);

            Assert.Equal(12, sqrt);

        }


    }
}