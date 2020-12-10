using System;
using System.Linq;
using System.Collections.Generic;


namespace _18.LinqReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            // int[] array2 = array.Reverse().ToArray();// Reverse() method takes array and reverses it elements!,so we create new reversed array2
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6 };

            array2 = array2.Reverse().ToArray();  // we overrite the content of the array 2 in inverted way.

            //Console.WriteLine("Content of array : {0}" , string.Join(" ", array));

            //Console.WriteLine("Content of Reveresed  array is : {0} ", string.Join("," , array2));
            // Concat() ->  combiones the two arrays togetherm, as if we create one array consisting of the two other arrays!
            // as if adding one array to other content;

            //Console.WriteLine(string.Join(" ", array.Concat(array2)));  //We print symtrical Array using the concat Method
            Console.WriteLine(array.Concat(array2).ToArray()[5]); //concatenate the two arrays together and from the new array take index-> 5

        }
    }
}
