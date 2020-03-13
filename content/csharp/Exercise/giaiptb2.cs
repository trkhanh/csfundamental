using System;

class Program
{
    static void Main() {
             int a, b, c;
            double d, x1, x2;
            Console.Write("\n");
            Console.Write("Giai phuong trinh bac hai trong C#:\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            //Console.Write("Nhap gia tri cua a: ");
            a = Convert.ToInt32(11);
            //Console.Write("\nNhap gia tri cua b: ");
            b = Convert.ToInt32(12);
            //Console.Write("\nNhap gia tri cua c: ");
            c = Convert.ToInt32(8);

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Nghiem duy nhat cua phuong trinh la = {0}\n", x1);
            }
            else if (d > 0)
            {
                Console.Write("Phuong trinh co hai nghiem thuc phan biet\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("Nghiem thu nhat: x1 = {0}\n", x1);
                Console.Write("Nghiem thu nhat: x2 = {0}\n", x2);
            }
            else
                Console.Write("Phuong trinh vo nghiem (hay khong co nghiem thuc nao)\n\n");   

           
    }
}