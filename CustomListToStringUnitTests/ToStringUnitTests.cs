﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListToStringUnitTests
{
    [TestClass]
    public class ToStringUnitTests
    {
        [TestMethod]
        public void To_String_Returns_Two_List_Int_In_One_String()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            string expected = "1, 2";
            string actual;

            actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void To_String_Return_Two_Bool_In_One_String()
        {
            CustomList<bool> list = new CustomList<bool>();
            list.Add(true);
            list.Add(false);
            string expected = "True, False";
            string actual;

            actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }

        
    }
}
