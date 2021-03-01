using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListZipMethodUnitTests
{
    [TestClass]
    public class ZipMethodUnitTests
    {
        [TestMethod]
        public void Zip_Method_Count_Is_Correct()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            CustList<int> list2 = new CustList<int>();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            CustList<int> list3 = new CustList<int>();
            int expected = 6;
            int actual;

            list3 = list1.Zip(list2);
            actual = list3.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Zip_Value_At_Index_One_Expected()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            CustList<int> list2 = new CustList<int>();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            CustList<int> list3 = new CustList<int>();
            int expected = 2;
            int actual;

            list3 = list1.Zip(list2);
            actual = list3[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_Value_At_Index_Two_Expected()
        {
            CustList<int> list1 = new CustList<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            CustList<int> list2 = new CustList<int>();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            CustList<int> list3 = new CustList<int>();
            int expected = 3;
            int actual;

            list3 = list1.Zip(list2);
            actual = list3[2];

            Assert.AreEqual(expected, actual);
        }
    }
}
