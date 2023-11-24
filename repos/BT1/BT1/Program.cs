using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Chuyen doi kieu du lieu trong C#");
            Console.WriteLine(".................");
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadLine();*/
            //..............
            Console.WriteLine("Hang so trong C#");
            Console.WriteLine("..............");

            //Khai bao hang so pi
            const double pi = 3.14159;

            double r;
            Console.Write("Nhap ban kinh: ");
            r = Convert.ToDouble(Console.ReadLine());
            double dien_tich = pi * r * r;
            Console.WriteLine("\nBan kinh:{0}, Dien tich: {1}", r, dien_tich);
            Console.ReadLine();

        }
    }
}
