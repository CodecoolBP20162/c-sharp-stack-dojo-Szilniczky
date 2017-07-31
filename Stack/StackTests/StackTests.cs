using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void StackTest()
        {
            Assert.IsNotNull(new Stack<int>(10));
        }

        [TestMethod()]
        public void PushTest()
        {
            var stack = new Stack<int>(12);
            stack.Push(3);
            stack.Push(4);
            Assert.AreEqual(10, stack.FreeSpacesLeft());
        }

        [TestMethod()]
        public void PopTest()
        {
            var stack = new Stack<string>(12);
            stack.Push("3");
            stack.Push("4");
            stack.Push("444");
            Assert.AreEqual("444", stack.Pop());
            Assert.AreEqual("4", stack.Pop());
            Assert.AreEqual("3", stack.Pop());
        }

        [TestMethod()]
        public void PeekTest()
        {
            var stack = new Stack<long>(12);
            stack.Push(1000000000);
            Assert.AreEqual(1000000000, stack.Peek());
            Assert.AreEqual(1000000000, stack.Pop());
        }
    }
}