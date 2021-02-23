using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace RemoveMethodUnitTests
{
    [TestClass]
    public class RemoveMethodUnitTests
    {
        [TestMethod]
        public void Remove_From_List_Count_Decreases()
        {
            CustomList<int> list = new CustomList<int>();
            int item = 1;
            int expected = 0;
            int actual;

            list.Add(item);
            list.Remove(item);
            actual = list.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_From_List_Item_At_Index_One_Shifts_To_Zero()
        {
            CustomList<int> list = new CustomList<int>();
            int item = 1;
            int item2 = 2;
            int expected = 2;
            int actual;

            
            list.Add(item);
            list.Add(item2);
            
            list.Remove(item);
            actual = list[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_Item_Removes_Only_First_Instance_Of_Item()
        {
            CustomList<int> list = new CustomList<int>();
            int item = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 1;
            int expected = 1;
            int actual;

            list.Add(item);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            list.Remove(1);
            actual = list[2];

            Assert.AreEqual(expected, actual);
        }
    }
}
