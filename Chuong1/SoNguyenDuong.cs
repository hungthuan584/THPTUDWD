using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class SoNguyenDuong
    {
        static void Main(string[] args)
        {
            int a;

            int t = -110;
            do
            {
                System.Console.WriteLine("Nhap vao so nguyen: ");
                a = int.Parse(System.Console.ReadLine());
                t += a;
            }
            while (t < 0);
            System.Console.WriteLine("Da nhan duoc so nguyen duong");
            Console.ReadLine();
        }
    }
}
