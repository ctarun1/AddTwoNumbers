using NUnit.Framework;
using AddTwoNumbers;
using System;
using System.IO;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program theProg = new Program();
            string[] args = new string[] { "Test1", "2", "10" };
            var ret = theProg.Main(new string[] { "Test1", "2", "10" });

            Assert.AreEqual(12, ret);
        }

        [Test]
        public void Test2()
        {
            Program theProg = new Program();
            string[] args = new string[] { "Test2", "-2", "10" };
            var ret = theProg.Main(new string[] { "Test1", "-2", "10" });

            Assert.AreEqual(8, ret);
        }

        [Test]
        public void Test3()
        {
            Program theProg = new Program();
            string[] args = new string[] { "Test3", "-20", "10" };
            var ret = theProg.Main(new string[] { "Test3", "-20", "10" });

            Assert.AreEqual(-10, ret);
        }
    }
}