using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            double r, chu_vi, dien_tich;
            double PI = 3.14;
            Console.Write("Nhap ban kinh duong tron: ");
            r = Convert.ToDouble(Console.ReadLine());
            chu_vi = 2 * PI * r;
            Console.WriteLine("\nChu vi duong tron la: {0}", chu_vi);
            dien_tich = PI * r * r;
            Console.WriteLine("Dien tich duong tron la: {0}", dien_tich);
            Console.Read();  

            Console.ReadKey();
        } 
    }
}