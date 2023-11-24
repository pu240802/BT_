using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tongquan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dong goi trong C#");
            Console.WriteLine("-----------------------");

            //Tao doi tuong Rectangle
            ClassRecTangle r = new ClassRecTangle();
            r.Acceptdetails();

            //thiet lap cac thuoc tinh


            // goi phuong thuc
            r.Display();
            Console.ReadLine();
        }
    }
}
