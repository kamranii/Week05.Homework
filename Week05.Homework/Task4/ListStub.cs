using System;
using System.Collections.Generic;

namespace Week05.Homework.Task4
{
    public class ListStub
    {
        public static List<string> ProcessToKill(List<string> process)
        {
            // Create list of string with initial size to 3.
            List<string> processToKill = new List<string>(3);

            // Show capacity ; here : 3.
            Console.WriteLine(string.Format("Capacity {0}", processToKill.Capacity));

            // Show number of items ; here : 0.
            Console.WriteLine(string.Format("Count {0}", processToKill.Count));

            /// TODO: 
            /// Add items from process to processToKill list 
            /// Process equals "Explorer.exe" don't be added, ignore it
            foreach(var item in process)
            {
                if(!item.Equals("Explorer.exe"))
                {
                    processToKill.Add(item);

                }
            }
            //Print out the capacity and the number of items after adding items  
            Console.WriteLine($"List Capacity after adding items from the {nameof(process)} list: {processToKill.Capacity}");
            Console.WriteLine($"Number of items in the {nameof(processToKill)}: {processToKill.Count}");
            foreach (var p in processToKill)
            {
                Console.WriteLine(p);
            }

            return processToKill;
        }
    }
}

