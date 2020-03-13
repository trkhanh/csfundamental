using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int canha, canhb, canhc;
            Console.Write("\n");
            Console.Write("Kiem tra tam giac deu, can, lech trong C#:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");



            Console.Write("Nhap canh a: ");
            canha = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh b: ");
            canhb = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh c: ");
            canhc = Convert.ToInt32(Console.ReadLine());



            if (canha == canhb && canhb == canhc)
            {
                Console.Write("Day la tam giac deu.\n");
            }
            else if (canha == canhb || canha == canhc || canhb == canhc)
            {
                Console.Write("Day la tam giac can.\n");
            }
            else
            {
                Console.Write("Day la tam giac lech.\n");
            }     

            Console.ReadKey();
        } 
    }
}