using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTest.Helpers;

namespace SoftwareTest.Tests
{
    [TestClass]
    public class LinkedListTester
    {
        [TestMethod]
        public void TestIf5ThElementInLinkedListIs5()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddToLinkedList(4);
            linkedList.AddToLinkedList(5);
            linkedList.AddToLinkedList(7);
            linkedList.AddToLinkedList(2);
            linkedList.AddToLinkedList(1);
            linkedList.AddToLinkedList(10);


            Assert.AreEqual(5, LinkedListHelper.GetElementAt(linkedList, 5),
                "Value is not equal to 5");
        }
    }
}
