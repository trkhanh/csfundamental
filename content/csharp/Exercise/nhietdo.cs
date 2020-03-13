using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int tmp;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# hien thi thong bao tuong ung voi nhiet do vua nhap:\n");
            Console.Write("------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap nhiet do ngoai troi: ");
            tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp < 0)
                Console.Write("Thoi tiet gia ret.\n");
            else if (tmp < 10)
                Console.Write("Thoi tiet rat lanh.\n");
            else if (tmp < 20)
                Console.Write("Thoi tiet lanh.\n");
            else if (tmp < 30)
                Console.Write("Thoi tiet binh thuong.\n");
            else if (tmp < 40)
                Console.Write("Thoi tiet nong.\n");
            else
                Console.Write("Thoi tiet ra nong.\n");    

            Console.ReadKey();
        } 
    }
}