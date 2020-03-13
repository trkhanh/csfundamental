using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            float p, c, m;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de xet tuyen Dai hoc:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Tieu chi xet tuyen:\n");
            Console.Write("Diem Toan >= 6.5\n");
            Console.Write("va diem Ly >= 5.5\n");
            Console.Write("va diem Hoa >= 5.0\n");
            Console.Write("va tong diem ba mon >= 18.0\n");
            Console.Write("hoac tong diem Toan va Ly >= 14.0\n");
            Console.Write("-------------------------------------\n");


            Console.Write("Nhap diem Ly: ");
            p = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem Toan: ");
            m = Convert.ToSingle(Console.ReadLine());
            Console.Write("Tong diem ba mon: {0}\n", m + p + c);
            Console.Write("Tong diem Toan va Ly: {0}\n", m + p);

            if (m >= 6.5)
                if (p >= 5.5)
                    if (c >= 5.0)
                        if ((m + p + c) >= 18.0 || (m + p) >= 14.0)
                            Console.Write("Chuc mung ban da trung tuyen.\n");
                        else
                            Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");
                    else
                        Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");
                else
                    Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");
            else
                Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");  

            Console.ReadKey();
        } 
    }
}