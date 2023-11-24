using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure2
{
    class Line1
    {
        private double chieu_dai;
        public Line1()
        {
            Console.WriteLine("Doi tuong dang duoc tao.");


        }
        public void setChieuDai(double len)
        {
            chieu_dai = len;
        }
        public double getChieuDai()
        {
            return chieu_dai;
        }
        ~Line1()
        {
            Console.WriteLine("Doi tuong dang bi xoa!!!");
        }





        internal class Program
        {
            public static void Details()
            {
                //tao doi tuong Line bang constructor
                Line1 line = new Line1();
                // thiet lap chieu dai cho duong
                line.setChieuDai(6.0);
                Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());

            }





            //
            class Line
            {
                private double chieu_dai;
                public Line()
                {
                    Console.WriteLine("Doi tuong dang duoc tao");

                }
                public void setChieuDai(double len)
                {
                    chieu_dai = len;
                }
                public double getChieuDai()
                {
                    return chieu_dai;
                }
                /// <summary>


                struct Book
                {
                    public string ten_sach;
                    public string tac_gia;
                    public string the_loai;
                    public int ma_sach;
                };
                struct Books
                {
                    private string ten_sach;
                    private string tac_gia;
                    private string the_loai;
                    private int ma_sach;
                    public void nhapGiaTri(string t, string a, string s, int id)
                    {
                        ten_sach = t;
                        tac_gia = a;
                        the_loai = s;
                        ma_sach = id;
                    }
                    public void Display()
                    {
                        Console.WriteLine("Tieu de:{0}", ten_sach);
                        Console.WriteLine("Tac gia:{0}", tac_gia);
                        Console.WriteLine("The loai:{0}", the_loai);
                        Console.WriteLine("Ma sach:{0}", ma_sach);
                    }
                }
                //class box
                class Box
                {
                    private double chieu_dai;
                    private double chieu_rong;
                    private double chieu_cao;
                    public void setChieuDai(double len)
                    {
                        chieu_dai = len;

                    }
                    public void setChieuRong(double bre)
                    {
                        chieu_rong = bre;
                    }
                    public void setChieuCao(double hei)
                    {
                        chieu_cao = hei;
                    }
                    public double tinhTheTich()
                    {
                        return chieu_dai * chieu_cao * chieu_rong;
                    }
                    //static
                    class ThanhVienStatic
                    {
                        public static int num;

                        public void count()
                        {
                            num++;
                        }
                        public static int getNum()
                        {
                            return num;
                        }
                    }
                    //tinh dong goi
                    class Rectangle
                    {
                        //cac bien thanh vien
                        public double length;
                        public double width;

                        //cac phuong thuc
                        public double GetArea()
                        {
                            return length * width;
                        }
                        public void Display()
                        {
                            Console.WriteLine("Chieu dai: {0}", length);
                            Console.WriteLine("Chieu rong: {0}", width);
                            Console.WriteLine("Dien tich: {0}", GetArea());
                        }
                        public void Acceptdetails()
                        {
                            Console.WriteLine("Nhap Chieu Dai: ");
                            length = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nhap Chieu Rong: ");
                            width = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    static void Main(string[] args)
                    {
                        
                        Console.WriteLine("1. Tinh dong goi");
                        Console.WriteLine("2. Bai chuoi ");

                        Console.WriteLine("3. VD Bai contructor");

                        Console.WriteLine("4. VD Bai class");
                        Console.WriteLine("0. Thoat");

                        int luachon;
                        int i = 1;
                        Console.WriteLine("Nhap lua chon: ");
                        luachon = Convert.ToInt32(Console.ReadLine());
                        while (i == 1)
                        {
                            
                            


                            switch (luachon)
                            {
                                case 1:
                                    Console.WriteLine("Tinh dong goi");
                                    //tinh dong goi
                                    Console.WriteLine("Tinh dong goi trong C#");
                                    Console.WriteLine("-------------------------------");

                                    // tao doi tuong Retangle
                                    Rectangle r = new Rectangle();
                                    // thiet lap cac thuoc tinh 
                                    r.length = 4.5;
                                    r.width = 3.5;
                                    // goi phuong thuc 
                                    r.Acceptdetails();
                                    r.Display();
                                    Console.ReadLine();

                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("VD1 Bai chuoi");
                                    //tao chuoi trong C#
                                    Console.WriteLine("Cac cach tao choi trong C#");
                                    Console.WriteLine("---------------------------");
                                    string fname, lname;
                                    fname = "Nguyen thi anh";
                                    lname = "Thu";
                                    string fullname = fname + " " + lname;
                                    Console.WriteLine("Ho va ten : {0}", fullname);
                                    char[] letters = { 'H', 'E', 'L', 'L', 'O' };
                                    string greetings = new string(letters);
                                    Console.WriteLine("\nLoi chao bang tieng anh:{0}", greetings);
                                    string[] sarray = { "C#", "xin", "chao", "cac", "ban" };
                                    string message = string.Join(" ", sarray);
                                    Console.WriteLine("\nThong diep:{0}", message);

                                    DateTime waiting = new DateTime(2020, 8, 1, 17, 58, 1);
                                    string chat = string.Format("Thong diep duoc gui luc {0:t} ngay {0:D}", waiting);
                                    Console.WriteLine("\nThong diep: {0}", chat);
                                    //so sanh chuoi
                                    Console.WriteLine("So sanh chuoi trong C#");
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
                                    //kiem tra chuoi
                                    Console.WriteLine("Kiem tra chuoi  con trong C#");
                                    Console.WriteLine("----------------");

                                    string str = "Chuoi con trong C#";
                                    if (str.Contains("trong"))
                                    {
                                        Console.WriteLine("Tim thay chuoi con 'trong'.");
                                    }
                                    //Lay chuoi con 
                                    Console.WriteLine("Lay chuoi con trong C#");
                                    Console.WriteLine("-----------------------");

                                    string s = "Lay chuoi con trong C#";
                                    Console.WriteLine("Chuoi ban dau: " + s);
                                    string substr = s.Substring(10);
                                    Console.WriteLine("Chuoi con: " + substr);



                                    //Noi chuoi
                                    Console.WriteLine("Noi chuoi trong C#");
                                    Console.WriteLine("----------------------");

                                    string[] starray = new string[] {"Hoc C# co ban va nang cao",
            "Chuong nay trinh bay ve chuoi trong C#",
            "Chung ta dang tim hieu ve noi chuoi trong C#",
            "Chuc cac em hoc tot."};
                                    string st = String.Join("\n", starray);
                                    Console.WriteLine(st);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine("VD Bai Contructor");
                                    Console.WriteLine("Destructor trong C#");
                                    Console.WriteLine("------");
                                    Details();
                                    GC.Collect();

                                    // tao doi tuong Line bang Construction
                                    Line line = new Line();

                                    //thiet lap chieu dai cho duong
                                    line.setChieuDai(6.0);
                                    Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());

                                    //struct
                                    Console.WriteLine("Struct trong C#");
                                    Console.WriteLine("-----------------\n");

                                    Book Book1;/* khai bao Book1 thuoc kieu cau truc book*/

                                    Book Book2;// khai bao Book2 thuoc kieu cau truc book

                                    //thong tin chi tiet ve Book1
                                    Book1.ten_sach = "English Grammar in Use";
                                    Book1.tac_gia = "Raymond Murphy";
                                    Book1.the_loai = "Tieng Anh";
                                    Book1.ma_sach = 6495407;

                                    // in cac thong tin cua Book2
                                    Book2.ten_sach = "Toan hoc cao cap";
                                    Book2.tac_gia = "Tran Van A";
                                    Book2.the_loai = "Toan hoc";
                                    Book2.ma_sach = 6495700;

                                    // in cac thong tin cua Book1
                                    Console.WriteLine("In thong tin  cua cuon sach 1:");
                                    Console.WriteLine("Ten sach: {0}", Book1.ten_sach);
                                    Console.WriteLine("Tac gia: {0}", Book1.tac_gia);
                                    Console.WriteLine("The loai: {0}", Book1.the_loai);
                                    Console.WriteLine("Ma sach: {0}", Book1.ma_sach);

                                    //in cac thong tin cua Book2
                                    Console.WriteLine("\n\nIn thong tin  cua cuon sach 2:");
                                    Console.WriteLine("Ten sach: {0}", Book2.ten_sach);
                                    Console.WriteLine("Tac gia: {0}", Book2.tac_gia);
                                    Console.WriteLine("The loai: {0}", Book2.the_loai);
                                    Console.WriteLine("Ma sach: {0}", Book2.ma_sach);

                                    //////
                                    Console.WriteLine("Struct trong C");
                                    Console.WriteLine("--------------");
                                    Books Books1 = new Books(); //Khai bao Book1 thuoc kieu cau truc Book
                                    Books Books2 = new Books(); //Khai bao Book2 thuoc kieu cau truc Book

                                    //Thong tin Book1
                                    Books1.nhapGiaTri("English Grammer in use", "Raymond Murphy", "Tieng Anh", 6495407);

                                    //Thong tin Book2
                                    Books2.nhapGiaTri("Toan hoc cao cap", "Tran Van A", "Toan hoc", 6495700);

                                    //In thong tin Book1
                                    Console.WriteLine("In thong tin cua cuon sach 1:");
                                    Books1.Display();
                                    //In thong tin Book2
                                    Console.WriteLine("In thong tin cua cuon sach 2:");
                                    Books2.Display();

                                    Console.WriteLine("Constructor trong C#");
                                    Console.WriteLine("---------------");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("VD Bai class");
                                    //class 
                                    Console.WriteLine("Class trong c#");
                                    Console.WriteLine("----------------");

                                    Box Box1 = new Box();
                                    Box Box2 = new Box();
                                    double thetich;

                                    //nhap thong tin cho box1
                                    Box1.setChieuDai(6.0);
                                    Box1.setChieuRong(7.0);
                                    Box1.setChieuCao(5.0);

                                    //nhap thong tin cho box2
                                    Box2.setChieuDai(12.0);
                                    Box2.setChieuRong(13.0);
                                    Box2.setChieuCao(10.0);

                                    //tinh va in the tich box1
                                    thetich = Box1.tinhTheTich();
                                    Console.WriteLine("The tich Box1 la: {0}", thetich);

                                    //tinh va in the tich box2
                                    thetich = Box2.tinhTheTich();
                                    Console.WriteLine("The tich Box2 la: {0}", thetich);

                                    // thanh vien static
                                    Console.WriteLine("Phuong thuc static trong c#");
                                    Console.WriteLine("----------------------------");

                                    //tao cac doi tuong thanh vien static 
                                    ThanhVienStatic a = new ThanhVienStatic();
                                    //goi phuon thuc

                                    a.count();
                                    a.count();
                                    a.count();

                                    Console.WriteLine("Gia tri cu num: {0}", ThanhVienStatic.getNum());
                                    Console.ReadKey();
                                    break;
                                case 0:
                                    i = 0;
                                    break;

                            }



                        }

                        }
                        
                        
                }

            }

        }
    }
}


