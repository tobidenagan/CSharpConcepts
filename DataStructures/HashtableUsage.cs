using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.DataStructures
{
    public class HashtableUsage
    {
        public static void HashtablePractice()
        {
            List<string> list = new() { "one", "two", "three", "four" };
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < list.Count; i++)
            {
                hashtable.Add(i, list[i]);
            }
            hashtable.Add("testValue", hashtable.ToString());
            foreach (var item in hashtable)
            {
                //Console.WriteLine($"Key is {item.}, Value is {item.Value}");
            }
        }
    }
}
