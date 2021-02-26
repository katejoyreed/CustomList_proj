using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListAddMethodUnitTests
{
    [TestClass]
    public class AddMethodUnitTests
    {
        [TestMethod]
        public void Add_Item_Count_Increases()
        {
            CustList<int> list = new CustList<int>();
            int number = 1;
            int expected = 1;
            int actual;

            list.Add(number);
            actual = list.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_Two_Items_Count_Increases_By_Two()
        {
            CustList<int> list = new CustList<int>();
            int number = 1;
            int number2 = 2;
            int expected = 2;
            int actual;

            list.Add(number);
            list.Add(number2);
            actual = list.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_Item_Replace_Array()
        {
            CustList<int> list = new CustList<int>();
            int item = 1;
            int expected = 8;
            int actual;

            while (list.Count < 5)
            {
                list.Add(item);
            }
            actual = list.Capacity;
          

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_Item_Replace_Array_Verify_Index_Four()
        {
            CustList<int> list = new CustList<int>();
            int item = 1;
            int expected = 1;
            int actual;

            while (list.Count < 5)
            {
                list.Add(item);
            }
            actual = list[4];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_Item_Replace_Array_Verify_Index_Zero()
        {
            CustList<int> list = new CustList<int>();
            int item = 1;
            int expected = 1;
            int actual;

            while (list.Count < 5)
            {
                list.Add(item);
            }
            actual = list[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_Integers_Second_Item_At_Index_One()
        {
            CustList<int> list = new CustList<int>();
            int item = 1;
            int item2 = 2;
            int item3 = 3;
            int expected = 2;
            int actual;

            list.Add(item);
            list.Add(item2);
            list.Add(item3);

            actual = list[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Integers_Third_Item_At_Index_Two()
        {
            CustList<int> list = new CustList<int>();
            int item = 1;
            int item2 = 2;
            int item3 = 3;
            int expected = 3;
            int actual;

            list.Add(item);
            list.Add(item2);
            list.Add(item3);

            actual = list[2];

            Assert.AreEqual(expected, actual);
        }


    }
}
