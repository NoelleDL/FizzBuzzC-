using NUnit.Framework;

namespace fizzBuzz.Library.Tests
{
    [TestFixture]
    public class fizzBuzzerTests
    {
        [Test]
        public void When1_Returns1()
        {
            int input = 1;
            string output = fizzBuzzer.GetValue(input);
            Assert.AreEqual("1", output);
        }

        [Test]
        public void When45_ReturnsFizzBuzz()
        {
            int input = 45;
            string output = fizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }

        [Test]
        public void When9_ReturnsFizz()
        {
            int input = 9;
            string output = fizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void When10_ReturnsBuzz()
        {
            int input = 10;
            string output = fizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

    }
}
