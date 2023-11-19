using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Graphs
{
    public static class DFT
    {
       static Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>
        {
            { 'a', new List<char> { 'c', 'b' } },
            { 'b', new List<char> { 'd' } },
            { 'c', new List<char> { 'e' } },
            { 'd', new List<char> { 'f' } },
            { 'e', new List<char>() },
            { 'f', new List<char>() }
        };

       public static void DepthFirstPrint(char source)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(source);

            while (stack.Count > 0)
            {
                char current = stack.Pop();
                Console.WriteLine(current);

                foreach (char neighbor in graph[current])
                {
                    stack.Push(neighbor);
                }
            }
        }


        //USING RECURSIVE : 

        public static void DepthFirstPrintRecursive(char source)
        {
           
                Console.WriteLine(source);

                foreach (char neighbor in graph[source])
                {
                DepthFirstPrintRecursive(neighbor);
                   
                }
            }
        }


    }



