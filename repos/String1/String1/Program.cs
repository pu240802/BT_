using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("So sanh chuoi trong C#");
            Console.WriteLine("----------------");

            string str1 = "So sanh chuoi trong C#";
            string str2 = "So sanh chuoi trong Csharp";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " va " + str2 + " la giong nhau.");

            }
            else
            {
                Console.WriteLine(str1 + " va " + str2 + " la khong giong nhau.");

            }
            Console.ReadKey();*/

            //vd2
            /*Console.WriteLine("Kiem tra chuoi  con trong C#");
            Console.WriteLine("----------------");

            string str = "Chuoi con trong C#";
            if (str.Contains("trong"))
            {
                Console.WriteLine("Tim thay chuoi con 'trong'.");
            }
            Console.ReadKey();*/
            // VD3

            Console.WriteLine("Cac ban tao chuoi trong C#");
            Console.WriteLine("-----------------------");

            //su dung phep gan hang chuoi va toan tu noi chuoi
            string fname, lname;
            fname = "Nguyen Thi Nhat";
            lname = "Phuong";

            string fullname = fname + " " + lname;
            Console.WriteLine("Ho va ten: {0}", fullname);

            // su dung construction cua lop string
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("\nLoi chao bang tien Anh: {0}", greetings);

            //tu cac phuong thuc ma tra ve mot chuoi
            string[] sarray = { "C#", "xin", "chao", "cac", "ban" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("\nThong diep: {0}", message);

            //dinh dang phuong thuc de chuyen  doi mot gia tri
            DateTime waiting = new DateTime(2022, 9, 13, 9, 02, 1);
            string chat = String.Format("Thong diep duoc gui luc {0:t} ngay {0:D}", waiting);
            Console.WriteLine("\nThong diep: {0}", chat);

            Console.ReadKey();


        }

    }
}
