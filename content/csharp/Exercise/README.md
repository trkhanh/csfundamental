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

#### Bài tập C#: Nhập 3 chữ cái và hiển thị theo chiều ngược lại

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

## Bài tập lệnh IF, ELSE, SWITCH trong C#
#### Bài tập C#: Nhập hai số và kiểm tra hai số có bằng nhau không
Đây là bài tập C# khá cơ bản minh họa cho bạn cách sử dụng của lệnh IF ELSE trong C#.
```c#
using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int int1, int2;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# kiem tra hai so co bang nhau khong:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap so thu nhat: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} va {1} la bang nhau.\n", int1, int2);
            else
                Console.WriteLine("{0} va {1} la khong bang nhau.\n", int1, int2);

            Console.ReadKey();
        } 
    }
}
```

### Bài tập C#: Kiểm tra chẵn lẻ

```c#
using System;

namespace ThayKhanhCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Kiem tra chan le trong C#:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} la so chan.\n", num1);
            else
                Console.WriteLine("{0} la so le.\n", num1);

            Console.ReadKey();
        } 
    }
}
```

### Bài tập C#: Kiểm tra một người có đủ tuổi bầu cử không
Yêu cầu bài tập C# này là nhập tuổi của một người, kiểm tra xem người đó có đủ tuổi bầu cử không, và sau đó in thông báo tương ứng. (Độ tuổi bầu cử là >= 18)

Đây là bài tập C# cơ bản minh họa giúp bạn cách sử dụng lệnh IF ELSE trong C#

#### Bài tập C#: Tìm số lớn nhất
Yêu cầu bài tập C# này là tìm số lớn nhất trong 3 số đã nhập từ bàn phím. Đây là bài tập C# cơ bản giúp bạn làm quen với lệnh IF ELSE trong C#.

#### Bài tập C#: Xét tuyển thi đại học
Yêu cầu bài tập C# này là nhập điểm thi ba môn Toán, Lý, Hóa của một thí sinh, kiểm tra theo tiêu chí đã cho, sau đó thông báo thí sinh có trúng tuyển hay không.
Tiêu chí:
Điểm Toán >= 6.5
Điểm Lý >= 5.5
Điểm Hóa >= 5.0
Tổng điểm ba môn >= 18.0
hoặc
Tổng điểm Toán và Vật lý >= 14.0

Đây là bài tập C# khá cơ bản minh họa cho bạn cách sử dụng của lệnh IF ELSE trong C#.


#### Bài tập C#: Nhập một nhiệt độ và in thông báo tương ứng
Hiển thị thông báo theo các tiêu chí sau:
Nhiệt độ < 0 thì thông báo là thời tiết giá rét
Nhiệt độ 0-10: thời tiết rất lạnh
Nhiệt độ 10-20: thời tiết lạnh
Nhiệt độ 20-30: thời tiết bình thường
Nhiệt độ 30-40: thời tiết nóng
Nhiệt độ >= 40: thời tiết rất nóng


#### Bài tập C#: Kiểm tra tam giác đều, cân, lệch
Nhập ba cạnh của một tam giác và kiểm tra xem tam giác đó là tam giác đều, tam giác cân hay tam giác lệch.

Đây là bài tập C# cơ bản minh họa giúp bạn cách sử dụng cấu trúc lệnh IF ... ELSE IF ... ELSE trong C#.

#### Bài tập C#: Kiểm tra lợi nhuận, thua lỗ
Yêu cầu bài tập C# này là nhập chi phí và doanh thu từ đó kết luận là lợi nhuận hay thua lỗ và với bao nhiêu.

Đây là bài tập C# cơ bản minh họa giúp bạn cách sử dụng cấu trúc lệnh IF ... ELSE IF ... ELSE trong C#.


#### Bài tập C#: Nhập hạng và hiển thị thông báo tương ứng
Yêu cầu bài tập C# này là nhập hạng học lực (ví dụ: A, B, C, ...) của một sinh viên và từ đó hiển thị thông báo tương ứng.

Hạng                  Thông báo
E                      Xuất sắc
V                      Rất giỏi
G                      Giỏi
A                      Trung bình
F                      Trượt
Đây là bài tập C# cơ bản minh họa giúp bạn cách sử dụng lệnh SWITCH ... CASE trong C#.


#### Bài tập C#: Nhập số và hiển thị số bằng chữ tương ứng
Yêu cầu bài tập C# này là nhập một số bất kỳ và hiển thị số bằng chữ tương ứng, ví dụ: 0 là số không, 1 là số một, ....

Đây là bài tập C# cơ bản minh họa giúp bạn cách sử dụng lệnh SWITCH ... CASE trong C#.