using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {
            int number1, number2, temp;
            Console.Write("\nNhap so dau tien: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nNhap so thu hai: ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nSau khi trao doi: ");
            Console.Write("\nGia tri cua number1 la: " + number1);
            Console.Write("\nGia tri cua number2 la: " + number2);
            Console.Read();  
        } 
    }
}