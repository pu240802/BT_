using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
   
    public class WebService1 : System.Web.Services.WebService
    {
        public int H()
        {
            return 0;
        }

        [WebMethod]
         
        public int Add(int x, int y)
        {
            return x + y;
        }
        [WebMethod]
        public int Sub(int x, int y)
        {
            return x - y;
        }
        [WebMethod]
        public int Mul(int x, int y)
        {
            return x * y;
        }
        [WebMethod]
        public int Div(int x, int y)
        {
            return x / y;
        }
        [WebMethod]
        public int Factoria(int x)
        {
            int fac = 1;
            for(int i = 1; i <= x; i++)
            {
                fac *= i;
            }
            return fac;
        }
        [WebMethod]
        public double Extract(int x, int y)
        {
           
            double temp;
            double sr = x / 2;

            do
            {
                temp = sr;
                sr = (temp + (x / temp)) / 2;
            } while ((temp - sr) != 0);
            return sr;
        }
        [WebMethod]
        public double Exponent(double x, double y)
        {
            double Kq = 0;
             Kq = Math.Pow(x, y);
            return Kq;

        }
       
       
            [WebMethod]

            public void DectoBin(int n)
            {

                Console.WriteLine("So {0} trong he co so 2 la: {1}", n, Convert.ToString(n, 2));



            }
        


    }
}
