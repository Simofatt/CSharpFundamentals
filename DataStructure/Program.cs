using DataStructure.Arrays;
using DataStructure.Dictionnary;
using DataStructure.Graphs;

namespace DataStructure

{
    class Program
    {
        public static void Main(string[] args)
        {

            //=====================================LINKED LIST===================================== 
            LinkedList<string> list =new LinkedList<string>();
            list.AddLast("Janvier");
            LinkedListNode<string> fervierNode = list.AddLast("Fervier");
            list.AddLast("Mars");
            list.AddLast("May");
            
           
            Console.WriteLine("The name of the months are : ");
            string Months2 = string.Join(" , ", list);
            Console.WriteLine($"The months after adding juin and juillet :  {Months2}");


            //AddAfter 
            LinkedListNode<string> JuinNode = list.AddLast("Juin");
            if (list.Contains("Juin")) list.AddAfter(JuinNode, "Juillet");
            string Months = string.Join(" , ",list); 
            Console.WriteLine($"The months after adding juin and juillet :  {Months}");



            //Remove 
            list.Remove("Mars");
            list.Remove(list.Last);
            Console.WriteLine("The months after deleting mars and juillet  are : ");
           Console.WriteLine(string.Join(" , " ,list));
           Console.WriteLine();




            Console.WriteLine("================================ PLAYING WITH ARRAYS==========================================");

            //Move a item of an array in the end 
            var array = ArrayLibrary.SwapArray(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2);
            Console.WriteLine($"Swaaping Array {string.Join(" , "  , array)}" );

            //sorting an array of ints 

            var arraySort = ArrayLibrary.SortAnAray(new[] { 1,3,2,5,4 });
            Console.WriteLine($"Swaaping Array {string.Join(" , ", arraySort)}");











            Console.WriteLine();
            Console.WriteLine("================================ PLAYING WITH DICTIONNARIES==========================================");
            Dictionnaries.Playing();






            //DEPTH FIRST TRAVERSAL : 

            DFT.DepthFirstPrint('a');
            Console.WriteLine("RECURSVIE DFT: ");
            DFT.DepthFirstPrintRecursive('a');

            //BREATH FIRST TRAVERSAL 
            Console.WriteLine(" BFT: ");
            BFT.BreathFirstPrint('a');




            //TWO DIM 
            TwoDim.Print();


            Console.ReadKey();
        }
    }
}