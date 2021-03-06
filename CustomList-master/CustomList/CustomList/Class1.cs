﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        private int count = 0;
        public int index;
        public int capacity = 4;
        public T[] array;

        public CustomList()
        {
            array = new T[capacity];
        }


        public int Count
        {
            get
            {
                return count;
            }
        }


        //count property


        //indexer

        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set => array[index] = value;
        }
        //add (capacity)

        public T[] IncreaseCapacity()
        {
            T[] newArray = new T[capacity * 2];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            return array;



            //double array, new array and erase old array, 
        }

        public void Add(T input)
        {



            if (count >= capacity)
            {
                IncreaseCapacity();
                array[count] = input;
                count++;
            }
            else
            {
                array[count] = input;
                count++;
            }

        }

        public void Remove(T input)
        {
            T[] newArray = new T[capacity];

            bool toggle = false;
            int tempCount = count;

            for (int i = 0; i < tempCount; i++)
            {
                if (array[i].Equals(input) && toggle == false)
                {
                    count--;
                    toggle = true;
                }
                else if (toggle == true)
                {
                    newArray[i - 1] = array[i];
                }
                else
                {
                    newArray[i] = array[i];
                }
            }
            array = newArray;


            //return newList;


        }



        public override string ToString()
        {
            string newString = "";

            for (int i = 0; i <= count; i++)
            {
                newString += (Convert.ToString(array[i]) + ", ");
            }

            return newString;





        }




        //overload add for two instances

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> listResult = new CustomList<T>();

            for (int i = 0; i < listOne.Count; i++)
            {
                listResult.Add(listOne[i]);
            }
            for (int i = listOne.Count; i < (listOne.Count + listTwo.Count); i++)
            {

                listResult.Add(listTwo[i - listOne.Count]);
            }
            return listResult;
        }
        //overload remove

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> listResult = new CustomList<T>();

            for (int i = 0; i <= listTwo.Count; i++)
            { for (int j = 0; j <= listOne.Count; j++)
                    if (listTwo[i].Equals(listOne[j]))
                    {
                        listOne.Remove(listOne[j]);
                        break;
                    }

                listResult = listOne;

                //else
                //{
                //    listResult.Add(listOne[j]);
                //        break;
                //}      
            }

            return listResult;
        }

        //zipper 

        public CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> listResult = new CustomList<T>();

            if (listOne.Count.Equals(listTwo.Count))
            {
                for (int i = 0; i <= (listOne.Count + listTwo.Count); i++)
                {
                    listResult.Add(listOne[i]);
                    listResult.Add(listTwo[i]);
                }

            }
            if (listOne.Count > listTwo.Count)
            {
                for (int i = 0; i <= listTwo.Count; i++)
                {
                    listResult.Add(listOne[i]);
                    listResult.Add(listTwo[i]);
                }
                for (int i = listTwo.Count; i <= listOne.Count; i++)
                {
                    listResult.Add(listOne[i]);
                }

            }
            if (listTwo.Count > listOne.Count)
            {
                for (int i = 0; i <= listOne.Count; i++)
                {
                    listResult.Add(listOne[i]);
                    listResult.Add(listTwo[i]);
                }
                for (int i = listOne.Count; i <= listTwo.Count; i++)
                {
                    listResult.Add(listOne[i]);
                }
            }
            return listResult;
        }



        public IEnumerator GetEnumerator()
        {
           

            for (int i = 0; i < Count; i++)

                yield return this[i];
        }


    }
}

