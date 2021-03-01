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
            CustList<int> list = new CustList<int>();
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
            CustList<int> list = new CustList<int>();
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
            CustList<int> list = new CustList<int>();
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

        [TestMethod]

        public void Remove_Two_Items_Count_Decreases_By_Two()
        {
            CustList<int> list = new CustList<int>();
            int item = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 1;
            int expected = 2;
            int actual;

            list.Add(item);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            list.Remove(item4);
            list.Remove(item2);

            actual = list.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_From_List_Element_At_Index_Four_Shifts_To_Index_Three()
        {
            CustList<int> list = new CustList<int>();
            int item = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 1;
            int item5 = 4;
            int expected = 4;
            int actual;

            list.Add(item);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            list.Add(item5);
            list.Remove(item);
            actual = list[3];

            

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]

        public void Remove_Method_Count_Remains_Same_If_Item_To_Remove_Is_Not_In_List()
        {
            CustList<int> list = new CustList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int expected = 5;
            int actual;

            list.Remove(6);
            actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
