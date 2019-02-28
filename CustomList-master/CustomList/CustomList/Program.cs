using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();


            CustomList<int> one = new CustomList<int>();
            one.Add(1);
            one.Add(3);
            one.Add(5);
        

            foreach (int thing in one)
            {
                Console.WriteLine(thing);
            }


               

        
        Console.ReadKey();
            
    }
    }
}
