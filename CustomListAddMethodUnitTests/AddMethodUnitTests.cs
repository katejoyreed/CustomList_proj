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
            CustomList<int> list = new CustomList<int>();
            int number = 1;
            int expected = 1;
            int actual;

            list.Add(number);
            actual = list.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_Item_ReplaceArray_Array()
        {
            CustomList<int> list = new CustomList<int>();
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

        public void Add_Integers_Second_Item_At_Index_One()
        {
            CustomList<int> list = new CustomList<int>();
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
    }
}
