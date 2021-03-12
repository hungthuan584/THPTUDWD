using System;

namespace Chuong1
{
    public class GiaiPTBac2
    {
        public void giaiPT1(float a, float b)
        {
            float x;
            x = (-b / a);
            if (a == 0) System.Console.WriteLine("Phuong trinh co vo so nghiem");
            else System.Console.WriteLine("Phuong trinh co nghiem x= {0}", x);

        }

        public void giaiPT2(float a, float b, float c)
        {
            float delta = b * b - 4 * a * c;
            if (delta < 0) System.Console.WriteLine("Phuong trinh vo nghiem!");
            else
            {
                if (delta == 0)
                {
                    float x = (-b / 2 * a);
                    System.Console.WriteLine("Phuong trinh co nghiem kep x1= x2= {0}", x);
                }
                else
                {
                    double x1, x2;
                    x1 = (-b + Convert.ToDouble(Math.Sqrt(delta))) / (2 * a);
                    x2 = (-b - Convert.ToDouble(Math.Sqrt(delta))) / (2 * a);
                    System.Console.WriteLine("Phuong trinh co 2 nghiem phan biet \nx1= {0} \nx2= {1}", x1, x2);
                }
            }
        }

        static void Main(string[] args)
        {
            float a, b, c;
            System.Console.WriteLine("Nhap vao so a: ");
            a = float.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Nhap vao so a: ");
            b = float.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Nhap vao so a: ");
            c = float.Parse(System.Console.ReadLine());

            GiaiPTBac2 pt = new GiaiPTBac2();
            if (a == 0) pt.giaiPT1(b, c);
            else pt.giaiPT2(a, b, c);
            Console.ReadLine();
            
        }
    }
}
