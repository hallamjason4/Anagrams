using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Anagrams
    {
        static void Main(string[] args)
        {
            string str = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            string[] splitAnags = str.Split(',');
            string targetString = "star";
            string targetStringOrd = String.Concat(targetString.OrderBy(y => y));

            foreach (var item in splitAnags)
            {
                string order = item;
                string x = String.Concat(order.OrderBy(y => y));
                if (x == targetStringOrd){
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
