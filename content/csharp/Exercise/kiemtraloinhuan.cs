using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int chi_phi, doanh_thu, loi_nhuan;

            Console.Write("\n\n");
            Console.Write("Kiem tra loi nhuan hoac thua lo trong C#:\n");
            Console.Write("-----------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap chi phi: ");
            chi_phi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia ban: ");
            doanh_thu = Convert.ToInt32(Console.ReadLine());

            if (doanh_thu > chi_phi)
            {
                loi_nhuan = doanh_thu - chi_phi;
                Console.Write("\nBan thu duoc loi nhuan: {0}\n", loi_nhuan);
            }
            else if (chi_phi > doanh_thu)
            {
                loi_nhuan = chi_phi - doanh_thu;
                Console.Write("\nBan thua lo: {0}\n", loi_nhuan);
            }
            else
            {
                Console.Write("\nBan khong thu duoc loi nhuan nhung cung khong thua lo.\n");
            }            

            Console.ReadKey();
        } 
    }
}