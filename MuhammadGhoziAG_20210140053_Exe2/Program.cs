﻿using System;
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

        //method 
        public void input()
        {
            // menerima angka menentukan data yang disimpan pada array 

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
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                ouzi[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan Hasil array yang telah tersusun 
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Element Array yang telah tersusun");
            Console.WriteLine("----------------------------------");

            for (int mg = 0; mg < n; mg++)
            {
                Console.WriteLine(ouzi[mg]);
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Program myList = new Program();

            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=============");
                    Console.WriteLine("1.Merge Search");
                    Console.WriteLine("2.Insertion Search");
                    Console.WriteLine("3.Exit");
                    Console.Write("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine(".................");
                            Console.WriteLine("Merge Search");
                            Console.WriteLine(".................");
                            myList.input();
                            myList.Merge();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine(".................");
                            Console.WriteLine("Insertion Search");
                            Console.WriteLine(".................");
                            myList.input();
                            myList.Insertion();
                            break;
                        case 3:
                            Console.WriteLine("exit.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Console.WriteLine("\nPilih Menu Lagi? (y/n) : ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                // to exit from the console 
                Console.WriteLine("\n\nPress Return to exit. ");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
