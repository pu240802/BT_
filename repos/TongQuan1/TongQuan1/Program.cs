using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TongQuan1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* char a1, a2, a3;
             Console.WriteLine("Nhap chu cai thu nhat:");
             a1 = Convert.ToChar(Console.ReadLine());

             Console.WriteLine("Nhap chu cai thu hai:");
             a2 = Convert.ToChar(Console.ReadLine());

             Console.WriteLine("Nhap chu cai thu ba:");
             a3 = Convert.ToChar(Console.ReadLine());

             Console.Write("Hien thi 3 chu cai theo chieu nguoc lai:");
             Console.WriteLine("{0} {1} {2}", a3, a2, a1);

             Console.ReadKey();*/


            // AX^2 + BX +C =0
            float a, b, c;
            Console.Write("Nhap he so bac 2, a = ");
            String valA = Console.ReadLine();
            a = Convert.ToInt32(valA);

            Console.Write("Nhap he so bac 1, b = ");
            String valB = Console.ReadLine();
            b = Convert.ToInt32(valB);


            Console.Write("Nhap he so bac 0, c = ");
            String valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            GPTB2(a, b, c);
            Console.ReadKey();






        }
        static void GPTB2 ( float a, float b, float c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem x = {0}", (-c / b));

                }
                return;

            }
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            if ( delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phuong trinh co 2 nghiem phan biet: x1 ={0} va x2= {0}", x1, x2);

            }else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phuong trinh co nghiem kep x1  = x2 ={0}", x1);

            }
            else
            {
                Console.Write("Phuong trinh vo nghiem!");
            }

        }
    }
}
