using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
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


        //count property online property


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
            //int oldSize = array.Length;
            //int newSize = capacity * 2;
            T[] newArray = new T[capacity * 2];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            //if (newArray.Length > array.Length)
            //{

            //    newArray = array;
            //    return array;
            //}

            //}
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

        public T[] Remove(T input)
        {
            T[] newArray = new T[capacity];
            bool toggle = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(input) && toggle == false)
                {
                    toggle = true;
                }
                else
                {
                    //newArray.Add(array[i]);
                    count++;
                }
                break;
            }
            //count--;
            array = newArray;
            return array;


        }


        //ToString

        //overload add for two instances

        //overload remove

        //zipper 

        //iterator



    }
}
