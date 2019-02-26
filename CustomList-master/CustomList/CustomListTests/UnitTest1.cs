using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_CheckCount_Increases()
        {
            //        -	Check if count increases

            //Arrange

            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;

            int expectedResult = 1;


            //Act
            list.Add(itemOne);
            int actualResult = list.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_AddValue_CorrectIndex()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            // int correctIndex;
            int itemOne = 5;
            int expectedResult = 5;

            //Act
            list.Add(itemOne);
            int actualResult = list[0];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_StringValue_CorrectString()
        {
            //-	Check if string value is correctly added

            //Arrange
            CustomList<string> list = new CustomList<string>();

            string itemOne = "5";


            string expectedResult;
            string actualResult;
            expectedResult = "5";

            //Act
            list.Add(itemOne);
            actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void Add_AddItems_LastIndex()
        {
            //-	Check if each added item appears at the last index of array

            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 3;
            int expectedResult;
            int actualResult;
            expectedResult = 3;

            //Arrange



            //Act

            list.Add(itemOne);
            list.Add(itemTwo);
            actualResult = list[list.Count - 1];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_AddValue_DoesNotDisturbOtherValues()
        {
            //-	

            //Arrange

            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 2;
            int actualResult;
            int expectedResult;
            expectedResult = 5;

            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Check_Capacity_DoublesCapacity()
        {
            //-	

            //Arrange

            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 2;
            int itemThree = 14;
            int itemFour = 6;
            int itemFive = 127;
            int actualResult;
            int expectedResult;
            expectedResult = 127;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);
            list.Add(itemThree);
            list.Add(itemFour);
            list.Add(itemFive);

            actualResult = list[4];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void Sub_RemoveItem_DecreaseCount()
        {
            //-	Check if count decreases

            //Arrange
            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 2;
            int actualResult;
            int expectedResult = 1;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);
            list.Remove(itemTwo);



            actualResult = list.Count;


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        public void Sub_RemoveItem_SpecificIndex()
        {
            //-	Check for value removed at specific index

            //Arrange
            CustomList<int> list = new CustomList<int>();

            int itemOne = 5;
            int itemTwo = 2;
            int expectedResult;
            int actualResult;

            //Act
            list.Add(itemOne);
            list.Add(itemTwo);
            list.RemoveAt(0);
            actualResult = list[0];
            expectedResult = 2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void Sub_LastIndex_ReturnsException()
        {
            //-	Check if last index of array returns exception

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int itemOne = 3;
            int itemTwo = 5;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);
            list.Remove(itemTwo);
            Console.WriteLine(list[1]);

            //Assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Remove.Sub_LastIndex_ReturnsException());


        }


        [TestMethod]
        public void Sub_RemoveItem_DoesNotDisturb()
        {
            //-	Check if removing item doesn't disturb other items

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int itemOne = 3;
            int itemTwo = 5;
            int expectedResult = 3;
            int actualResult;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);
            list.Remove(itemTwo);
            actualResult = list[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void Sub_RemoveItem_RemovesIntended()
        {
            //-	Check if removing item doesn't disturb other items
            // remove method always removes the first instance it encounters.

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int itemOne = 3;
            int itemTwo = 5;
            int itemThree = 6;
            int itemFour = 5;

            int expectedResult = 6;
            int actualResult;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);
            list.Add(itemThree);
            list.Add(itemFour);
            list.Remove(5);
            actualResult = list[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }


        //        -	Check that every index of new array is string

        [TestMethod]
        public void ToString_StringItem_IsString()
        {
           

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int itemOne = 3;
            int itemTwo = 5;
           

            int expectedResult = "5";
            int actualResult;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);
            
            list.ToString(5);
            actualResult = list[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }


        //-	Check that strings converted to strings are still strings

        [TestMethod]
        public void ToString_StartingString_IsString()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            string itemOne = "3";
            string itemTwo = "5";


            int expectedResult = "5";
            int actualResult;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            list.ToString("5");
            actualResult = list[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        //-	Check that items remained at same index
        //-	Check to see that int as strings are still strings
        //-	Check to see that count is the same





    }
}