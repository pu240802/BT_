using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LTHDT.TestCSharp1;

namespace LTHDT
{
    //Tinh Ke thua VD1
    class Shape1
    {
        protected int chieu_rong;
        protected int chieu_cao;
        public void setChieuRong(int w)
        {
            chieu_rong = w;
        }
        public void setChieuCao(int h)
        {
            chieu_cao = h;
        }
    }
    class Rectangle : Shape1
    {
        public int tinhDienTich()
        {
            return (chieu_cao * chieu_rong);
        }
    }

    //Tinh Ke thua VD2
    class Shape
    {
        protected int chieu_rong;
        protected int chieu_cao;


        public void setChieuRong(int w)
        {
            chieu_rong = w;
        }
        public void setchieuCao(int h)
        {
            chieu_cao = h;
        }
    }
    public interface ChiPhiSon
    {
        int tinhChiPhi(int dien_tich);
    }
    class HinhChuNhat : Shape, ChiPhiSon
    {
        public int tinhDienTich()
        {
            return (chieu_rong * chieu_cao);
        }
        public int tinhChiPhi(int dien_tich)
        {
            return dien_tich * 70;
        }
    }
    //Tinh ke thua VD3
    class Shape3
    {
        protected int chieu_rong;
        protected int chieu_cao;
        public void setChieuRong(int w)
        {
            chieu_rong = w;
        }
        public void setChieuCao(int h)
        {
            chieu_cao = h;
        }
    }
    public interface ChiPhiSon3
    {
        int tinhChiPhi(int dien_tich);
    }
    class HinhChuNhat3 : Shape3, ChiPhiSon3
    {
        public int tinhDienTich()
        {
            return (chieu_rong * chieu_cao);
        }
        public int tinhChiPhi(int dien_tich)
        {
            return dien_tich * 70;
        }
    }

    //VD Da Hinh1
    public class TestCSharp1
    {
        void print(int i)
        {
            Console.WriteLine("In so nguyen: {0}", 1);
        }
        void print(double f)
        {
            Console.WriteLine("In so thuc: {0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("In chuoi: {0}", s);
        }

        abstract class Shape4
        {
            public abstract int tinhDientich4();
        }
        class HinhChuNhat4 : Shape4
        {
            private int chieu_dai;
            private int chieu_rong;
            public HinhChuNhat4(int a = 0, int b = 0)
            {
                chieu_dai = a;
                chieu_rong = b;
            }
            public override int tinhDientich4()
            {
                Console.WriteLine("Dien tich hinh chu nhat: ");
                return (chieu_rong * chieu_dai);
            }
        }

        //VD Da Hinh2
        class Shape5
        {
            protected int chieu_rong, chieu_cao;
            public Shape5(int a = 0, int b = 0)
            {
                chieu_rong = a;
                chieu_cao = b;
            }
            public virtual int tinhDienTich5()
            {
                Console.WriteLine("Dien tich cua class cha: ");
                return 0;
            }
        }

        class HinhChuNhat5 : Shape5
        {
            public HinhChuNhat5(int a = 0, int b = 0) : base(a, b)
            {

            }
            public override int tinhDienTich5()
            {
                Console.WriteLine("Dien tich cua class HinhchuNhat: ");
                return (chieu_rong * chieu_cao);
            }
        }

        class TamGiac : Shape5
        {
            public TamGiac(int a = 0, int b = 0) : base(a, b)
            {

            }
            public override int tinhDienTich5()
            {
                Console.WriteLine("Dien tich cua class TamGiac: ");
                return (chieu_rong * chieu_cao / 2);
            }
        }

        class HienThiDuLieu
        {
            public void hienthiDienTich5(Shape5 sh)
            {
                int b;
                b = sh.tinhDienTich5();
                Console.WriteLine("Dien tich: {0}", b);
            }
        }

        //VD Nap chong toan tu
        class Box
        {
            private double chieu_dai;
            private double chieu_rong;
            private double chieu_cao;
            public double tinhTheTich()
            {
                return chieu_dai * chieu_rong * chieu_cao;
            }
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
            //nap chong toan tu + de cong hai doi tuong Box
            public static Box operator +(Box b, Box c)
            {
                Box box = new Box();
                box.chieu_dai = b.chieu_dai + c.chieu_dai;
                box.chieu_rong = b.chieu_rong + c.chieu_rong;
                box.chieu_cao = b.chieu_cao + c.chieu_cao;
                return box;
            }
        }

        //VD INTERFACE
        public interface ITransactions
        {
            //các thành viên của interface

            //các phương thức

            void hienThiThongTinGiaoDich();
            double laySoLuong();
        }
        public interface GiaoDich
        {
            //cac thanh vien cua interface

            //cac phuong thuc
            void hienThiThongTinGiaoDich();
            double laySoLuong();
        }

        class GiaoDichHangHoa : GiaoDich
        {
            private string ma_hang_hoa;
            private string ngay;
            private double so_luong;
            public GiaoDichHangHoa()
            {
                ma_hang_hoa = " ";
                ngay = " ";
                so_luong = 0.0;
            }

            public GiaoDichHangHoa(string c, string d, double a)
            {
                ma_hang_hoa = c;
                ngay = d;
                so_luong = a;
            }

            public double laySoLuong()
            {
                return so_luong;
            }

            public void hienThiThongTinGiaoDich()
            {
                Console.WriteLine("Ma hang hoa: {0}", ma_hang_hoa);
                Console.WriteLine("Ngay giao dich: {0}", ngay);
                Console.WriteLine("So luong: {0}", laySoLuong());
            }
        }

        public class TestCsharp
        {
            internal class Program
            {




                static void Main(string[] args)
                {
                    Console.WriteLine("Menu VD");
                    Console.WriteLine("1.Tinh Ke thua");
                    Console.WriteLine("2.Tinh Da ke thua");
                    Console.WriteLine("3.Nap chong toan tu");
                    Console.WriteLine("4.Interface");
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
                                // Tinh ke thua VD1
                                Console.WriteLine("\n\nVD1");
                                Console.WriteLine("Tinh ke thua trong C#");
                                Console.WriteLine("---------------------------------------\n");
                                Rectangle hcn = new Rectangle();
                                hcn.setChieuRong(5);
                                hcn.setChieuCao(7);
                                Console.WriteLine("Dien tich hinh chu nhat :{0}", hcn.tinhDienTich());


                                // Tinh ke thua VD2
                                Console.WriteLine("\n\nVD2");
                                Console.WriteLine("Tinh ke thua trong C#");
                                Console.WriteLine("Vi du minh hoa Da ke thua");
                                Console.WriteLine("-----------------------------");
                                //tao doi tuong
                                HinhChuNhat hcn1 = new HinhChuNhat();
                                int dien_tich;
                                hcn1.setChieuRong(5);
                                hcn1.setchieuCao(7);
                                dien_tich = hcn1.tinhDienTich();
                                Console.WriteLine("Tong dien tich: {0}", hcn1.tinhDienTich());
                                Console.WriteLine("Tong chi phi son: {0}", hcn1.tinhChiPhi(dien_tich));



                                //Tinh ke thua VD3
                                Console.WriteLine("\n\nVD3");
                                Console.WriteLine("Tinh ke thua trong C#");
                                Console.WriteLine("Ví du minh hoa da ke thua");
                                Console.WriteLine("--------------------------");

                                //tao doi tuong HinhChuNhat
                                HinhChuNhat3 hcn3 = new HinhChuNhat3();
                                int dien_tich3;
                                hcn3.setChieuRong(5);
                                hcn3.setChieuCao(7);
                                dien_tich3 = hcn3.tinhDienTich();

                                //in dien tich va chi phi
                                Console.WriteLine("Tong dien tich: {0}", hcn3.tinhDienTich());
                                Console.WriteLine("Tong chi phi son: {0}", hcn3.tinhChiPhi(dien_tich));
                                Console.ReadLine();
                                break;
                            case 2:

                                //VD1 Da Hinh
                                Console.WriteLine("\n\nVD1");
                                Console.WriteLine("Tinh da hinh trong C#");
                                Console.WriteLine("Vi du minh hoa Da hinh dong");
                                Console.WriteLine("----------------------------");
                                //tao doi tuong TestSharp
                                TestCSharp1 p = new TestCSharp1();

                                //goi ham print
                                p.print(5);
                                p.print(500.263);
                                p.print("Hoc C# co ban va nang cao");

                                HinhChuNhat4 r = new HinhChuNhat4(10, 7);
                                double a = r.tinhDientich4();
                                Console.WriteLine("Dien tich: {0}", a);



                                //Da Hinh VD2
                                Console.WriteLine("\n\nVD2");
                                Console.WriteLine("Tinh da hinh trong C#");
                                Console.WriteLine("Ví dụ minh hoa Da hinh dong");
                                Console.WriteLine("----------------------------");

                                HienThiDuLieu c = new HienThiDuLieu();
                                HinhChuNhat5 d = new HinhChuNhat5(10, 7);
                                TamGiac e = new TamGiac(10, 5);
                                c.hienthiDienTich5(d);
                                c.hienthiDienTich5(e);

                                Console.ReadKey();
                                break;
                            case 3:

                                //VD Nap chong toan tu
                                Console.WriteLine("Nap chong toan tu trong c#");
                                Console.WriteLine("Vi du minh hoa cap chong toan tu");
                                Console.WriteLine("-------------------------------");
                                //tao cac doi tuong Box1, Box2, Box3
                                Box Box1 = new Box();
                                Box Box2 = new Box();
                                Box Box3 = new Box();
                                double the_tich = 0.0;

                                //nhap thong tin Box1
                                Box1.setChieuDai(6.0);
                                Box1.setChieuRong(13.0);
                                Box1.setChieuCao(5.0);

                                //nhap tong tin Box2
                                Box2.setChieuDai(12.0);
                                Box2.setChieuRong(13.0);
                                Box2.setChieuCao(10.0);

                                //tich va hien the tich Box1
                                the_tich = Box1.tinhTheTich();
                                Console.WriteLine("The tich cua Box1 la: {0}", the_tich);

                                //thic va hien the tich Box2
                                the_tich = Box2.tinhTheTich();
                                Console.WriteLine("The tich cua Box1 la: {0}", the_tich);

                                //con hai doi tuong
                                Box3 = Box1 + Box2;

                                //tich va hien thi the tich Box3
                                the_tich = Box3.tinhTheTich();
                                Console.WriteLine("The tich cua Box3 la : {0}", the_tich);
                                Console.ReadKey();
                                break;
                            case 4:

                                //VD Interface
                                Console.WriteLine("Interface trong C#");
                                Console.WriteLine("Vi du minh hoa interface");
                                Console.WriteLine("-------------------------");

                                //tao cac doi tuong GiaoDichHangHoa
                                GiaoDichHangHoa t1 = new GiaoDichHangHoa("001", "8/10/2012", 78900.00);
                                GiaoDichHangHoa t2 = new GiaoDichHangHoa("002", "9/10/2012", 451900.00);
                                t1.hienThiThongTinGiaoDich();
                                t2.hienThiThongTinGiaoDich();

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
