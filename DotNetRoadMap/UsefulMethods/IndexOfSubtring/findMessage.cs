using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulMethods.IndexOfSubtring
{
    public static class findMessage
    {
       public static void getMsg(string message)
        {
            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                message = message.Substring(closingPosition + 1);
            }

        }

        public static void removeSomething()
        {
            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            
            Console.WriteLine(message);
        }
    }
}
