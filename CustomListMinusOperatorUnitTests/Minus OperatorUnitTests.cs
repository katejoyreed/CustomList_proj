using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListMinusOperatorUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Minus_Operator_Zero_Index_Correct()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            CustList<int> list2 = new CustList<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(4);
            CustList<int> list3 = new CustList<int>();
            int expected = 3;
            int actual;

            list3 = list1 - list2;
            actual = list3[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Minus_Operator_Multiple_Instances_Of_Common_Int_Are_Removed()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(7);
            CustList<int> list2 = new CustList<int>();
            list2.Add(1);
            list2.Add(3);
            list2.Add(5);
            CustList<int> list3 = new CustList<int>();
            int expected = 7;
            int actual;

            list3 = list1 - list2;
            actual = list3[0];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Minus_Operator_Nothing_Count_Remains_Same_If_No_Shared_Values()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(7);
            CustList<int> list2 = new CustList<int>();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            CustList<int> list3 = new CustList<int>();
            int expected = 4;
            int actual;

            list3 = list1 - list2;
            actual = list3.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
