using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    public class GiaiPTBac1
    {
        public void giaiPT1(float a,float b)
        {
            float x;
            x = (-b / a);
            if (a == 0) System.Console.WriteLine("Phuong trinh co vo so nghiem");
            else System.Console.WriteLine("Phuong trinh co nghiem x= {0}",x);
            
        }
        static void Main(string[] args)
        {
            int a, b;
            System.Console.WriteLine("Nhap vao so a: ");
            a = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Nhap vao so b: ");
            b = int.Parse(System.Console.ReadLine());

            GiaiPTBac1 pt = new GiaiPTBac1();
            pt.giaiPT1(a, b);
            Console.ReadLine();
        }
    }
}
