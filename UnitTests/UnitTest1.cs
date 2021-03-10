using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            task.Task task1 = new task.Task(1, 1, 1);
            int positive;
            int negative;
            task1.AnswerTask(out positive, out negative);
            Assert.AreEqual(3, positive);
            Assert.AreEqual(0, negative);
        }
        [TestMethod]
        public void TestMethod2()
        {
            task.Task task1 = new task.Task(-1, -1, 0);
            int positive;
            int negative;
            task1.AnswerTask(out positive, out negative);
            Assert.AreEqual(0, positive);
            Assert.AreEqual(2, negative);
        }

        
    }
}
