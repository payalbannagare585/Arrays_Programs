using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Array
{
    internal class StrArrayDemo
    {
            static void Main(string[] args)
            {
                String[] names = new String[5] {"Payal","Bhushan","chanchal","vivek","Gaurav"};
                String[] nams = new String[5];
                Console.WriteLine("Original array");

                foreach (String i in names)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("sorted array");
                Array.Sort(names);


                Array.Reverse(names);
                Array.Clear(names, 2, 2);
                Array.Copy(names, 1, nams, 0, 3);
                Array.Copy(names, nams, names.Length);
                int index = Array.IndexOf(names, "Chanchal");
                Console.WriteLine($"index of Chanchal is {index}");
                foreach (String i in nams)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }


