namespace Sum_CICD.Tests
{
    public class SumTest
    {
        private readonly SumClass _sum;

        public SumTest()
        {
            _sum = new();
        }

        [Fact]
        public void Should_Return_Sum_Of_Two_Integers()
        {
            Assert.Equal(5, _sum.Sum(2, 3));
        }

        [Fact]
        public void Should_Return_Sum_Of_Two_Negative_Integers()
        {
            Assert.Equal(-5, _sum.Sum(-2, -3));
        }

        [Fact]
        public void Should_Return_Sum_Of_Two_Mixed_Integers()
        {
            Assert.Equal(1, _sum.Sum(-2, 3));
        }
    }
}