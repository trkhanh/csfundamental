using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int tuoi_bau_cu;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# de kiem tra tuoi bau cu:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap tuoi cua cu tri bat ky: ");
            tuoi_bau_cu = Convert.ToInt32(Console.ReadLine());
            if (tuoi_bau_cu < 18)
            {
                Console.Write("Xin loi!!! Ban chua du tuoi de tham gia bau cu.\n");
                Console.Write("Ban co the tham gia bau cu sau {0} nam nua.\n\n", 18 - tuoi_bau_cu);
            }
            else
                Console.Write("Chuc mung!!! Ban du tuoi de lam cu tri.\n\n");

            Console.ReadKey();
        } 
    }
}