using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int cdigit;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap so va hien thi so bang chu tuong ung:\n");
            Console.Write("-------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so bat ky (0-9): ");
            cdigit = Convert.ToInt32(Console.ReadLine());

            switch (cdigit)
            {
                case 0:
                    Console.Write("So khong\n");
                    break;

                case 1:
                    Console.Write("So mot\n");
                    break;
                case 2:
                    Console.Write("So hai\n");
                    break;
                case 3:
                    Console.Write("So ba\n");
                    break;
                case 4:
                    Console.Write("So bon\n");
                    break;
                case 5:
                    Console.Write("So nam\n");
                    break;
                case 6:
                    Console.Write("So sau\n");
                    break;
                case 7:
                    Console.Write("So bay\n");
                    break;
                case 8:
                    Console.Write("So tam\n");
                    break;
                case 9:
                    Console.Write("So chin\n");
                    break;
                default:
                    Console.Write("Ban da nhap so khong hop le. Xin nhap lai!!!\n");
                    break;
            }               

            Console.ReadKey();
        } 
    }
}