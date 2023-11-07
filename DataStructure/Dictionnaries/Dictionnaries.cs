using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Dictionnary
{
    public static class Dictionnaries
    {
        public static void Playing() {


            Dictionary<string,int> disc = new Dictionary<string, int>();

            disc.Add("first",  1);
            disc.Add("second", 2);

            //GET THE VALUE BASED ON THE KEY
            disc.TryGetValue("first", out var value); 
            Console.WriteLine("GETTING THE VALUE BASED ON THE KEY FIRST WAY : ");

            var value2 = disc["first"];
            Console.WriteLine("FIRST WAY : "+value+ "SECOND WAY : " + value2);
         

            //GET THE KEY BASED ON THE VALUE
            var key = disc.Where((item,key) => item.Value == 1).FirstOrDefault().Key;
            Console.WriteLine("THE KEY BASED ON THE VALUE : "+key);
            
            //PRINTING ALL THE ELEMENTS : 
            foreach(var item in disc)  Console.WriteLine($"ItemValue : {item.Value} item key :   {item.Key}");
         

        }
    }
}
