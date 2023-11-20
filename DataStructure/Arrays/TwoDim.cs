using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    public static class TwoDim
    {

        //2D ARRAY : ARRAY THAT CONTAINS MULTIPLE DIMENSIONN ROWS AND COLLUMNS

        static char[,] charArray = new char[,]
        {
            { 'A', 'B', 'C' },
            { 'D', 'E', 'F' },
            { 'G', 'H', 'I' }
        };

        //JUNKED ARRAY :  ARRAY THAT CONTAINS MULTIPLE ARRAYS

        static char[][] charArray2 = new char[][]
     {
           new char[] { 'A', 'B', 'C' },
           new char[]  { 'D', 'E', 'F' },
           new char[] { 'G', 'H', 'I' }
     };



        public static void Print()
        {
            var rows = charArray.GetLength(0);
            var coll = charArray.GetLength(1);

            var rows2 = charArray2.Length;

            foreach( var item in charArray2)
            {
                for (var i = 0; i < rows; i++)
                {
                    Console.WriteLine(item[i]);
                }
            }



            for(var i =0; i < rows; i++) { 

                for(var j =0; j < coll; j++)
                {

                    Console.WriteLine(charArray[i,j]);
                }
            
            }



        }
    }
}
