using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            string notes;
            char grd;
            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap hang hoc luc va in thong bao tuong ung\n");
            Console.Write("--------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap hang hoc luc: ");
            grd = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grd)
            {
                case 'E':
                    notes = "  Xuat sac";
                    break;
                case 'V':
                    notes = "  Rat gioi";
                    break;
                case 'G':
                    notes = "  Gioi ";
                    break;
                case 'A':
                    notes = "  Trung binh";
                    break;
                case 'F':
                    notes = "  Truot";
                    break;
                default:
                    notes = "Ban da nhap hang hoc luc khong dung. Xin thu lai!!!";
                    break;
            }
            Console.Write("Hoc luc cua ban la: {0}\n", notes);            

            Console.ReadKey();
        } 
    }
}