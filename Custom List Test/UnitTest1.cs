using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Test;

namespace Custom_List_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 25;
            int expected = 25;
            int actual;

            //Act
            testList.Add(itemToAdd);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }  
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            //Act
            testList.Add(itemToAdd);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        } 
        public void Add_AddingMultipleValueToEmptyCustomList_()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 5;
            int actual;

            //Act
            testList.Add(itemToAdd);
           
            actual = testList.Count++;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddingMultipleValueToEmptyCustomList_IncreasingCapacityCount()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int[] itemsToAdd = new int[4];
            itemsToAdd = new int[8];
            int actual;

            //Act
            testList.Add(itemToAdd);

            actual = testList.Count++;

            //Assert
        }
       
    } 
}
