using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class SoNhoNhat
    {
        static void Main(string[] args)
        {
            int a, b, c;

            System.Console.WriteLine("Nhap vao so a: ");
            a = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Nhap vao so b: ");
            b = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Nhap vao so c: ");
            c = int.Parse(System.Console.ReadLine());

            int min = a;
            if (min >= b) min = b;
            else
            {
                if (min >= c) min = c;
            }

            System.Console.WriteLine("So nho nhat la: {0}",min);
            Console.ReadLine();
        }
    }
}
