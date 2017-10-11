using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuNhat
{
    public class ChuNhat
    {
        private double cd;
        private double cr;

        public ChuNhat()
        {
            this.cd = 0;
            this.cr = 0;
        }
        public ChuNhat(double a,double b)
        {
            this.cd = a;
            this.cr = b;
        }
        public ChuNhat(ChuNhat a)
        {
            this.cd = a.cd;
            this.cr = a.cr;
        }

        public void nhap()
        {
            Console.Write("Chieu dai: ");
            this.cd = Double.Parse(Console.ReadLine());
            Console.Write("Chieu rong: ");
            this.cr = Double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Hinh Chu Nhat Co: ");
            Console.WriteLine("Chieu dai = {0}", this.cd);
            Console.WriteLine("Chieu rong = {0}", this.cr);
        }
        public double chuvi()
        {
            return 2 * (this.cd + this.cr);
        }
        public double dientich()
        {
            return this.cd * this.cr;
        }
        public void ktHCN()
        {
            if (this.cd > this.cr)
                Console.WriteLine("Hinh Chu Nhat");
            else
                Console.WriteLine("Ko Hinh Chu Nhat");
        }
    }
}
