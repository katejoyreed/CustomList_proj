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

        public void Add_Item_Create_New_Array()
        {
            CustomList<int> list = new CustomList<int>();
            
        }
    }
}
