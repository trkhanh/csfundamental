using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            char letter, letter1, letter2;

            Console.Write("Nhap chu cai thu nhat: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap chu cai thu hai: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap chu cai thu ba: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Hien thi 3 chu cai theo chieu nguoc lai: ");
            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter); 

            Console.ReadKey();
        } 
    }
}