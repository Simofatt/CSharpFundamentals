using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Graphs
{

    //BREATH FIRST TREAVERSAL 
    public static class BFT
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
        public static void BreathFirstPrint(char source)
        {

            Queue<char> queue = new Queue<char>();  
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current);


                foreach (var neighboor in graph[current])
                {
                    queue.Enqueue(neighboor);
                }
            }

        }

    }
}
