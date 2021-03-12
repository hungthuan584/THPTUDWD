using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class SoNguyenTo
    {
        bool check(int a)
        {
            bool h = false;
            int d = 0;
            if (a == 1) h = false;
            else
            {
                for (int i = 2; i < Math.Sqrt(a); i++)
                    if (a % i == 0) d += 1;
            }
            if (d > 0) h = true;
            return h;
        }

        static void Main(string[] args)
        {
            int a;
            System.Console.WriteLine("Nhap vao so a; ");
            a = int.Parse(System.Console.ReadLine());

            SoNguyenTo snt = new SoNguyenTo();
            bool check = snt.check(a);
            if (check == true) System.Console.WriteLine("So {0} la so nguyen to", a);
            else System.Console.WriteLine("So {0} khong la so nguyen to", a);
            Console.ReadLine();
        }
    }
}
