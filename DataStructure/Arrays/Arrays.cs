using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    public static class ArrayLibrary
    {
        // SWAPP AN ELEMENT OF AN ARRAY :
        // USING LINQ
        public static int[] SwapArray(int[] arr , int elementToMove)
        {
            var indexOfTheElementToMove = Array.IndexOf(arr, elementToMove);    
            var newArray = arr.Where((value,index) => index !=indexOfTheElementToMove).ToArray();
            newArray = newArray.Concat(new[] {elementToMove}).ToArray(); 
            return newArray ;
        }
        //USING LINKED LIST 
        public static int[] SwapArraysUsingLinkedList(int[] arr, int elementToMove) { 
            
            LinkedList<int> list = new LinkedList<int>(arr);   
            list.AddLast(elementToMove);
            list.Remove(elementToMove);
            
            return list.ToArray();

        
        }


        //sorting an array   [1,5,8,3,1]
        public static int[] SortAnAray(int[] arr)
        {
           var temp= arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j =i+1; j < arr.Length; j++)
                {

                    if (arr[j] > arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
            } 
            }
            return arr;
        }


        

    }
}
