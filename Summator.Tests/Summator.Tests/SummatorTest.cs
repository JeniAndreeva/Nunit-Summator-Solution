using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            int actual = Summator.Sum(new int[] { 5, 7 });

            int expected = 12;

            Assert.That(expected == actual);

            //int expected = Summator.Sum(new int[] { 5, 7 });
            //int actual = 12;

            //Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            int actual = Summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumber()
        {
            int actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            int actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new long[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(6000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            double actual = Summator.Average(new double[] { 6, 3 });

            double expected = 4.5;

            Assert.That(expected == actual);
        }
        [Test]

        public void TestValueIsInRange()
        {
            double persentage = 67.85;

            Assert.That(persentage, Is.InRange(50, 100));
        }

        [Test]

        public void TestContainsString()
        {
            string Student = "Gosho Ivanov";

            Assert.That(Student, Does.Contain("Ivanov"));
        }
    }
}