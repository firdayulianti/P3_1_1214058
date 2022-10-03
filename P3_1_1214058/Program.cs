using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan jumlah anak ayam: ");
            var jumanakayam = int.Parse(Console.ReadLine());
            var jumanakayam2 = jumanakayam - 1;
            Console.WriteLine(" ");

            if (jumanakayam >= 1 && jumanakayam <= 10)
            {
                for (int i = jumanakayam; i > 0; i--)
                {
                    if (i > 1)
                    {
                        var j = i - 1;
                        Console.WriteLine("Anak ayam turunlah " + i + ", mati satu tinggallah " + j);
                    }
                    else { Console.WriteLine("Anak ayam turunlah 1, mati satu tinggallah induknya"); }
                }
            }
            else { Console.WriteLine("Nilai n tidak valid"); }
        }
    }
}          
