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
        [TestMethod]

        public void Plus_Operator_Third_List_Capacity_Correct()
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
            int expected = 16;
            int actual;

            list3 = list1 + list2;
            actual = list3.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Operator_Index_Six_Is_Expected()
        {
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            CustomList<int> list2 = new CustomList<int>();
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);
            list2.Add(10);

            CustomList<int> list3 = new CustomList<int>();
            int expected = 7;
            int actual;

            list3 = list1 + list2;
            actual = list3[6];

            Assert.AreEqual(expected, actual);
        }
    }
}
