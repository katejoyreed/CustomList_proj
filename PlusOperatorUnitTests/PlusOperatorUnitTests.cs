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
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            CustList<int> list2 = new CustList<int>();
            list2.Add(2);
            CustList<int> list3 = new CustList<int>();
            int expected = 2;
            int actual;

            list3 = list1 + list2;
            actual = list3[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Plus_Operator_Third_List_Count_Correct()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);

            CustList<int> list2 = new CustList<int>();
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);

            CustList<int> list3 = new CustList<int>();
            int expected = 10;
            int actual;

            list3 = list1 + list2;
            actual = list3.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Plus_Operator_Third_List_Capacity_Correct()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);
            list1.Add(1);

            CustList<int> list2 = new CustList<int>();
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);
            list2.Add(2);

            CustList<int> list3 = new CustList<int>();
            int expected = 16;
            int actual;

            list3 = list1 + list2;
            actual = list3.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Operator_Index_Six_Is_Expected()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            CustList<int> list2 = new CustList<int>();
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list2.Add(9);
            list2.Add(10);

            CustList<int> list3 = new CustList<int>();
            int expected = 7;
            int actual;

            list3 = list1 + list2;
            actual = list3[6];

            Assert.AreEqual(expected, actual);
        }
    }
}
