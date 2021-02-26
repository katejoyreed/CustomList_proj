using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace PlusOperatorUnitTests
{
    [TestClass]
    public class PlusOperatorUnitTests
    {
        [TestMethod]
        public void Plus_Operator_Combines_Two_Collections()
        {
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(2);
            CustomList<int> list3 = new CustomList<int>();
            int expected = 2;
            int actual;

            list3 = list1 + list2;
            actual = list3[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Plus_Operator_Third_List_Count_Correct()
        {
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);

            CustomList<int> list2 = new CustomList<int>();
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);

            CustomList<int> list3 = new CustomList<int>();
            int expected = 10;
            int actual;

            list3 = list1 + list2;
            actual = list3.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
