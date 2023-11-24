using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN2
{
    class CanBo
    {
        public string HoTen;
        public string NamSinh;
        public string GioiTinh;
        public string DiaChi;
        public void SetHoTen(string A)
        {
            HoTen = A;
        }
        public void SetGioTinh(string Nam)
        {
            GioiTinh = Nam;
        }
        public void SetDiaChi(string HCM)
        {
            DiaChi = HCM;
        }
        public virtual void Nhap()
        {
            Console.Write("\nNhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("\nNhap nam sinh : ");
            NamSinh = Console.ReadLine();
            Console.Write("\nNhap gioi tinh : ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap dia chi :");
            DiaChi = Console.ReadLine();

        }
        public virtual void Xuat()
        {
            Console.Write("\nHo ten : {0}", this.HoTen);
            Console.Write("\nNam sinh : {0}", this.NamSinh);
            Console.Write("\nGioi tinh : {0}", this.GioiTinh);
            Console.Write("\nDia chi : {0}", this.DiaChi);
        }

        class CongNhan : CanBo
        {
            public string Bac;
            public void setBac(string bac)
            {
                Bac = bac;
            }
            public virtual void Nhap()
            {
                CanBo canbo1 = new CanBo();
                canbo1.Nhap();
                Console.Write("\nNhap bac cong nhan : ");
                Bac = Console.ReadLine();
            }
            public void Xuat()
            {
                Console.Write("\nBac cong nhan : {0}", this.Bac);
            }
        }
        class NhanVien : CanBo
        {
            public string CongViec;
        }
        class KySu : CanBo
        {
            public string NganhDaoTao;
        }
    }


internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n = ");
            n = System.Convert.ToInt32(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //CongNhan a = new CongNhan();
                CanBo canbo = new CanBo();
                //  CongNhan canbo1 = new ();
                CanBo bac1 = new CanBo();
                canbo.Nhap();
                canbo.Xuat();
                Console.ReadKey();
            }
        }
     }
 }
