using NUnit.Framework;
using Problems;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private Solutions solution;

        [SetUp]
        public void Init()
        {
            solution = new Solutions();
        }

        [TestCase(new int[] { 3,3 }, new int[] { 0, 1 }, 6)]
        [TestCase(new int[] { 1, 3, 4, 5 }, new int[] { 2, 3 }, 9)]
        [TestCase(new int[] { 1, 3, 4, 5 }, new int[] { 0, 3 }, 6)]
        [TestCase(new int[] { 9, 0 , 8, 3 }, new int[] { 1, 3 }, 3)]
        [TestCase(new int[] { 9, 0, 8, 3 }, new int[] { 0, 2 }, 17)]
        [TestCase(new int[] { 9, 0, 8, 3 }, new int[] { 0, 2 }, 17)]
        public void TwoSum_Brute(int[] args, int[] target, int sum)
        {
            Assert.AreEqual(target, solution.TwoSum_Brute(args, sum));
        }

        [TestCase(new int[] { 3, 3 }, new int[] { 0, 1 }, 6)]
        [TestCase(new int[] { 1, 3, 4, 5 }, new int[] { 2, 3 }, 9)]
        [TestCase(new int[] { 1, 3, 4, 5 }, new int[] { 0, 3 }, 6)]
        [TestCase(new int[] { 9, 0, 8, 3 }, new int[] { 1, 3 }, 3)]
        [TestCase(new int[] { 9, 0, 8, 3 }, new int[] { 0, 2 }, 17)]
        [TestCase(new int[] { 9, 0, 8, 3 }, new int[] { 0, 2 }, 17)]
        public void TwoSum_SingleHash(int[] args, int[] target, int sum)
        {
            Assert.AreEqual(target, solution.TwoSum_SingleHash(args, sum));
        }

        [TestCase("", 0)]
        [TestCase("+1", 1)]
        [TestCase(".1", 0)]
        [TestCase("+-2", 0)]
        [TestCase("   -42", -42)]
        [TestCase("words and 987", 0)]
        [TestCase("4193 with words", 4193)] 
        [TestCase("56456andNoWords",56456)]
        [TestCase("-91283472332", int.MinValue)]
        [TestCase("20000000000000000000", 2147483647)]
        [TestCase("9223372036854775808", int.MaxValue)]
        [TestCase("-91283472332andNoWords", int.MinValue)]
        public void MyAtoi(string arg, int outcome)
        {
            Assert.AreEqual(outcome, solution.MyAtoi(arg));
        }


        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(1534236469, 0)]
        [TestCase(int.MinValue, 0)]
        public void Reverse(int arg, int result)
        {
            Assert.AreEqual(result, solution.Reverse(arg));
        }
    }
}
