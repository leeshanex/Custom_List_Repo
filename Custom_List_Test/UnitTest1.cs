using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Proj;

namespace Custom_List_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OnePostiveInteger_CheckIndexZero()
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
        public void Add_OnePositiveInteger_CountEqualsOne()
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
        [TestMethod]
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
        [TestMethod]
        public void Add_ThreePositiveValues_CheckIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int expected = 5;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositiveValues_CheckIndexOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int expected = 8;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList[1];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreePositiveValues_CheckCapacity()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int expected = 4;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_CheckCount()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int value4 = 144;
            int value5 = 288;
            int expected = 5;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            actual = testList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_CheckCapacity()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int value4 = 144;
            int value5 = 288;
            int expected = 8;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            actual = testList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_CheckIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int value4 = 144;
            int value5 = 288;
            int expected = 5;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            actual = testList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FivePositiveValues_CheckIndexFour()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int value4 = 144;
            int value5 = 288;
            int expected = 288;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            actual = testList[4];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveOne_CheckIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 12;
            int value4 = 144;
            int value5 = 288;
            int expected = 8;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Remove(value1);
            actual = testList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveOne_CheckCount()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 144;
            int value2 = 144;
            int value3 = 144;
            int value4 = 144;
            int value5 = 144;
            int expected = 4;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Remove(144);
            actual = testList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ThreePostiveValueRemoveTwo_CheckCapacity()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 144;
            int value2 = 144;
            int value3 = 144;
            int expected = 4;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value1);
            actual = testList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FivePositiveValuesRemoveOne_CheckCapacity()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 144;
            int value2 = 144;
            int value3 = 144;
            int value4 = 144;
            int value5 = 144;
            int expected = 4;
            int actual;
            //Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Remove(value5);
            actual = testList.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }   
}
