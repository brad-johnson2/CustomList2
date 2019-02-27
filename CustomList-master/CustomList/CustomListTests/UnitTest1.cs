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
            list.Remove(list[0]);
            actualResult = list[0];
            expectedResult = 2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
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
            Console.WriteLine(list[5]);

            //Assert

         


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

        //[TestMethod]
        //public void ToString_StringItem_IsString()
        //{


        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    int itemOne = 3;
        //    int itemTwo = 5;


        //    string expectedResult = "5";
        //    int actualResult;


        //    //Act
        //    list.Add(itemOne);
        //    list.Add(itemTwo);

        //    list.ToString(5);
        //    actualResult = list[1];

        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);


        //}


        ////-	Check that strings converted to strings are still strings

        //[TestMethod]
        //public void ToString_StartingString_IsString()
        //{


        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    string itemOne = "3";
        //    string itemTwo = "5";


        //    int expectedResult = "5";
        //    int actualResult;


        //    //Act
        //    list.Add(itemOne);
        //    list.Add(itemTwo);

        //    list.ToString("5");
        //    actualResult = list[1];

        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);


        //}

        ////-	Check that items remained at same index

        [TestMethod]
        public void ToString_IndexValue_RemainsSame()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            int itemOne = 3;
            int itemTwo = 5;


            string expectedResult = "typeof(string)";
            string actualResult;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            list.ToString();
           // actualResult = list.GetType();

            //Assert
            //Assert.AreEqual(expectedResult, actualResult);


        }
        //-	Check to see that int as strings are still strings

        [TestMethod]
        public void ToString_OneItem_CorrectCount()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            int itemOne = 3;
            


            int expectedResult = 1;
            int actualResult;


            //Act
            list.Add(itemOne);
            

            list.ToString();
            actualResult = list.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        //-	Check to make sure first item of second array follows last item of first

        [TestMethod]
        public void Addition_LastIndexOne_PrecedesFirstIndexTwo()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();


            int itemOne = 3;
            int itemTwo = 5;
            int itemThree = 6;
            int itemFour = 2;

            

            int expectedResultOne = 5;
            int expectedResultTwo = 6;
            int actualResultOne;
            int actualResultTwo;


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);


            listThree = list + listTwo;
            actualResultOne = listThree[1];
            actualResultTwo = listThree[2];

            //Assert
            Assert.AreEqual(expectedResultOne, actualResultOne);
            Assert.AreEqual(expectedResultTwo, actualResultTwo);


        }





        //-	Make sure count equals sum of individual counts

        [TestMethod]
        public void Addition_NewCount_SumPreviousCounts()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();


            int itemOne = 3;
            int itemTwo = 5;
            int itemThree = 6;
            int itemFour = 2;



            int expectedResult = 4;
          
            int actualResult;
     


            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);


            listThree = list + listTwo;
            actualResult = listThree.Count;
           

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        //-	Make sure items when “added” aren’t summed with other items

        [TestMethod]
        public void Addition_TwoItems_AreNotSummed()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();


            int itemOne = 3;
            int itemTwo = 3;
            int itemThee = 3;
            int itemFour = 3;



            int expectedResult = 3;
            int summedResult = 6;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThee);
            listTwo.Add(itemFour);


            listThree = list + listTwo;
            actualResult = listThree[0];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreNotEqual(summedResult, actualResult);

        }
        //-	Make sure it works with strings

        //[TestMethod]
        //public void Addition_StringInput_Works()
        //{


        //    //Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    CustomList<int> listTwo = new CustomList<int>();
        //    CustomList<int> listThree = new CustomList<int>();


        //    string itemOne = "3";
        //    string itemTwo = "5";
        //    string itemThree = "6";
        //    string itemFour = "2";



        //    string expectedResult = "2";

        //    int actualResult;



        //    //Act
        //    list.Add(itemOne);
        //    list.Add(itemTwo);

        //    listTwo.Add(itemThree);
        //    listTwo.Add(itemFour);


        //    listThree = list + listTwo;
        //    actualResult = listThree[3];


        //    //Assert
        //    Assert.AreEqual(expectedResult, actualResult);

        //}
        //-	Check to make sure all of array one is added before any of array two

        [TestMethod]
        public void Addition_AllOneAdded_BeforeTwo()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();


            int itemOne = 3;
            int itemTwo = 3;
            int itemThree = 6;
            int itemFour = 6;



            int expectedResultOne = 3;
            int expectedResultTwo = 6;

            int actualResultOne;
            int actualResultTwo;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);


            listThree = list + listTwo;
            actualResultOne = listThree[1];
            actualResultTwo = listThree[2];


            //Assert
            Assert.AreEqual(expectedResultOne, actualResultOne);
            Assert.AreNotEqual(expectedResultTwo, actualResultTwo);

        }



        [TestMethod]
        public void Subtraction_FirstHasMultipleValue_CorrectNumberRemoved()
        {

            //-	Make sure that if multiple items I the first array, the correct number are being removed
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int itemOne = 3;
            int itemTwo = 3;
            int itemThree = 3;
            int itemFour = 2;



            int expectedResult = 3;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);


            listThree = list - listTwo;
            actualResult = listThree[0];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }



        //-	Check that none of the values in the second array are in the result array

        [TestMethod]
        public void Subtraction_FirstHasValueInSecond_ValueIsRemoved()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int itemOne = 3;
            int itemTwo = 2;
            int itemThree = 3;
            int itemFour = 6;



            int expectedResult = 2;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);


            listThree = list - listTwo;
            actualResult = listThree[0];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        //-	Make sure values in first array are being “subtracted” and not subtracted 

        [TestMethod]
        public void Subtraction_IsBeingRemoved_NotDifferenced()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int itemOne = 3;
            int itemTwo = 2;
            int itemThree = 3;
            int itemFour = 6;



            int expectedResult = 2;
            int subbedValue = 0;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);


            listThree = list - listTwo;
            actualResult = listThree[0];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreNotEqual(subbedValue, actualResult);

        }

        //-	Check to make sure the order is correct after “subtraction”
        [TestMethod]
        public void Subtraction_ResultValues_CorrectOrder()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int itemOne = 3;
            int itemTwo = 2;
            int itemThree = 6;
            int itemFour = 3;



            int expectedResult = 6;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);


            listThree = list - listTwo;
            actualResult = listThree[1];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }



        //-	If one array is bigger, make sure overflow is added at the end
        [TestMethod]
        public void Zipper_OneArrayIsBigger_AddedAtEnd()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int itemOne = 3;
            int itemTwo = 2;
            int itemThree = 6;
            int itemFour = 3;
            int itemFive = 11;
            int itemSix = 13;



            int expectedResult = 13;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);
            listTwo.Add(itemFive);
            listTwo.Add(itemSix);



            listThree = Zip(listOne, listTwo);
            actualResult = listThree[5];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        //-	Check to see if new array is alternating between the two

        [TestMethod]
        public void Zipper_UsesTwo_Alternates()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int itemOne = 3;
            int itemTwo = 2;
            int itemThree = 6;
            int itemFour = 3;
           


            int expectedResult = 6;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);
          



            listThree = Zip(list, listTwo);
            actualResult = listThree[1];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }



        //-	Make sure that if both arrays have the same value at the same index, they’re in the correct order
        [TestMethod]
        public void Zipper_SameValue_CorrectAlternates()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();

            int itemOne = 3;
            int itemTwo = 2;
            int itemThree = 3;
            int itemFour = 3;



            int expectedResult = 3;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThree);
            listTwo.Add(itemFour);




            listThree = Zip(list, listTwo);
            actualResult = listThree[1];


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


        //-	Check to see if new count is the sum of the individual counts

        [TestMethod]
        public void Zipper_NewCount_SumPreviousCounts()
        {


            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listThree = new CustomList<int>();


            int itemOne = 3;
            int itemTwo = 5;
            int itemThee = 6;
            int itemFour = 2;



            int expectedResult = 4;

            int actualResult;



            //Act
            list.Add(itemOne);
            list.Add(itemTwo);

            listTwo.Add(itemThee);
            listTwo.Add(itemFour);


            listThree = Zip(list, listTwo);
            actualResult = listThree.Count;


            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }



    }
}