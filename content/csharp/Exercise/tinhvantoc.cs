using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            float quang_duong;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Nhap quang duong (don vi met): ");
            quang_duong = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap thoi gian - so gio: ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap thoi gian - so phut: ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap thoi gian - so giay: ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = quang_duong / timeSec;
            kph = (quang_duong / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Van toc la {0} m/s", mps);
            Console.WriteLine("Van toc la {0} km/h", kph);
            Console.WriteLine("Van toc la {0} mile/h", mph); 

            Console.ReadKey();
        } 
    }
}