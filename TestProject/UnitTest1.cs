using App;

namespace TestProject
{
    public class Tests
    {
        SumNumbers sumNumbers;

        [SetUp]
        public void Setup()
        {
            sumNumbers = new SumNumbers();
        }

        [Test]
        public void WhenTwoNumbersSumIsTwelve()
        {
            var sum = 12;

            int[] ints = { 1, 9, 5, 0, 20, -4, 12, 16, 7 };

            List<KeyValuePair<int, int>> pairs = sumNumbers.GetSumNumbers(ints, sum);

            Assert.IsTrue(pairs[0].Key == 5 && pairs[0].Value == 7 && pairs[1].Key == 0 && pairs[1].Value == 12 && pairs[2].Key == -4 && pairs[2].Value == 16);
        }

        [Test]
        public void WhenTwoNumbersSumIsThirty()
        {
            var sum = 30;

            int[] ints = { 1, 9, 5, 0, 20, -4, 12, 16, 10 };

            List<KeyValuePair<int, int>> pairs = sumNumbers.GetSumNumbers(ints, sum);

            Assert.IsTrue(pairs[0].Key == 20 && pairs[0].Value == 10);
        }
    }
}