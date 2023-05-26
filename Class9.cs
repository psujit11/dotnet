using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class ArrList
    {
        static public void Arl()
        {
            var arlist = new ArrayList()
                {
                    1,
                    "Name",
                    300,
                    4.5f
                };


            //Add
            arlist.Add(true);
            arlist.Add(null);
            int[] arr = { 6, 4 };
            arlist.AddRange(arr);

            //Insert
            arlist.Insert(6, 18);
            int[] arr2 = { 15, 51 };
            arlist.InsertRange(3, arr2);

            //Remove
            arlist.Remove(6);
            arlist.RemoveAt(2);
            arlist.RemoveRange(4, 2);

            Console.WriteLine($"Contains Name? => {arlist.Contains("Name")}");

        }
    }
}
