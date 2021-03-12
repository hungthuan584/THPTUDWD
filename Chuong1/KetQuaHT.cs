using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class KetQuaHT
    {
        static void Main(string[] args)
        {
            string hoten;
            float diem;

            System.Console.WriteLine("Nhap ho ten sinh vien: ");
            hoten = System.Console.ReadLine();
            System.Console.WriteLine("Nhap diem: ");
            diem = float.Parse(System.Console.ReadLine());

            string ht = hoten.ToUpper();
            string loai;
            if (diem >= 8) loai = "Gioi";
            else
                if (diem >= 6.5 && diem < 8) loai = "Kha";
            else
                    if (diem >= 6 && diem < 6.5) loai = "Trung binh";
                    else loai = "Yeu";

            System.Console.WriteLine("{0} \nDiem: {1} \nXep loai: {2}", ht, diem, loai);
            Console.ReadLine();
        }
    }
}
