using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhammadGhoziAG_20210140053_Exe2
{
    class Program
    {
        // Deklarasi array int dengan ukuran maksimal 28
        private int[] ouzi = new int[28];

        // Deklarasi variable yang digunakan untuk menyimpan nilai data pada array
        private int n;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine
                        ("\nArray should have minimum 1 and maximum 20 elements. \n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                ouzi[i] = Int32.Parse(s1);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
