using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int n1, n2;
            bool bothEven;
            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven = ((n1 % 2 == 0)
                && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ?
              "Ca hai so deu la so chan" :
              "Hai so khong phai deu la so chan"); 

            Console.ReadKey();
        } 
    }
}