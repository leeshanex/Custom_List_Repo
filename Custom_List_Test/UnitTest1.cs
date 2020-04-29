﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Proj;

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
        public void Add_FourPostiveInteger_CountEqualsFour()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int value4 = 144;
            int expected = 4;
            int actual;

            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void 

       
        
    }
}
