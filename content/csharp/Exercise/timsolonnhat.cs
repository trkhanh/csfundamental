using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int num1, num2, num3;
            Console.Write("\n");
            Console.Write("Chuong trinh C# de tim so lon nhat trong 3 so:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so thu nhat: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("So thu nhat la so lon nhat trong ba so. \n\n");
                }
                else
                {
                    Console.Write("So thu ba la so lon nhat trong ba so. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("So thu hai la so lon nhat trong ba so.\n\n");
            else
                Console.Write("So thu ba la so lon nhat trong ba so. \n\n");

            Console.ReadKey();
        } 
    }
}