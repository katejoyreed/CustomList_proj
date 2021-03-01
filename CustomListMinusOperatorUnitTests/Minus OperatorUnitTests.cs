﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
