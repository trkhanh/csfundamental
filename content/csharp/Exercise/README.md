### Dưới đây là danh sách các bài tập về kiểu dữ liệu trong C#.

#### Bài tập C#: Tìm tổng hai số
Yêu cầu bài tập C# này là tính tổng hai số và sau đó hiển thị kết quả trên màn hình. Đây là bài tập C# cơ bản giúp bạn làm quen với cấu trúc chương trình C# và cách hiển thị kết quả trên màn hình.

```c#
using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {
            System.Console.Write("Tong cua hai so 15 va 17 la: ");
            System.Console.WriteLine(15 + 17);  
            System.Console.WriteLine("\n----------------------------\n");
            System.Console.WriteLine("ThayKhanh chuc cac ban hoc tot !!!");
            Console.ReadKey();
        } 
    }
}
```
#### Bài tập C#: Chuyển đổi độ C thành độ K và độ F
Công thức chuyển đổi độ C thành độ K và độ F như sau:
1 K = 1 C + 273
1 F = C * 18/10 + 32
```c#
using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {
            Console.Write("Nhap do C: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do K tuong ung la = {0}", celsius + 273);
            Console.WriteLine("Do F tuong ung la = {0}", celsius * 18 / 10 + 32);
            Console.ReadKey();
        } 
    }
}
```

#### Bài tập C#: Nhập 3 chữ cái và hiển thị theo chiều ngược lại

#### Bài tập C#: Tìm giá trị trung bình
Nhập 4 số từ bàn phím và sau đó tìm và hiển thị giá trị trung bình của 4 số này trên màn hình Console. Đây là một bài tập C# cơ bản giúp bạn làm quen với cách nhập dữ liệu từ bàn phím và làm quen với cấu trúc chương trình C#.

```c#
using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        public static void Main()
        {
            int number1, number2, number3, number4;

            Console.Write("Nhap so thu nhat: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu tu: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            int result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("Gia tri trung binh cua {0} , {1} , {2} , {3} la: {4} ",
            number1, number2, number3, number4, result); 
            Console.ReadKey();
        } 
    }
}
```
#### Bài tập C#: Kiểm tra chẵn lẻ
Nhập hai số từ bàn phím, trả về true nếu cả hai số cùng chẵn, nếu không thì trả về false.

Đây là bài tập C# giúp bạn làm quen với kiểu dữ liệu int và kiểu dữ liệu bool và cách sử dụng toán tử điều kiện biểu_thức ? giá_trị_1 : giá_trị_2.

#### Bài tập C#: Vẽ tam giác số
Nhập một số và vẽ tam giác số với độ rộng theo bề ngang là một số khác được nhập từ bàn phím. Ví dụ, với số 4 và độ rộng là 5 thì chúng ta có tam giác:
````
4 4 4 4 4
4 4 4 4
4 4 4
4 4
4
````
Bài tập C# này ngoài giúp bạn làm quen với cách nhập dữ liệu, hiển thị và cách khai báo biến còn giúp bạn làm quen với cách sử dụng vòng lặp (trong bài mình sử dụng vòng lặp for) trong C#.

#### Bài tập C#: Kiểm tra tên đăng nhập và mật khẩu
Viết chương trình C# để nhận Username và Password dưới dạng kiểu dữ liệu string từ người dùng. Nếu người dùng nhập sai quá 3 lần, in thông báo lỗi.

Đây là chương trình C# cơ bản giúp bạn làm quen với kiểu dữ liệu string trong C# cũng như thực hiện phép toán với kiểu dữ liệu này.

#### Bài tập C#: Tìm chu vi và diện tích hình tròn
Yêu cầu bài tập C# là nhập bán kính hình tròn sau đó tìm và hiển thị chu vi và diện tích hình tròn đó.

Đây là bài tập C# cơ bản giúp bạn làm quen với kiểu dữ liệu double trong C#.

#### Bài tập C#: cho quãng đường và thời gian, tìm vận tốc
Yêu cầu bài tập C# là với quãng đường và thời gian đã cho, bạn tìm vận tốc với các đơn vị m/s, km/h, mile/h.

Đây là bài tập C# cơ bản giúp bạn làm quen với các kiểu dữ liệu trong C#.