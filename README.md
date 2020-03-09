# .NET Đào tạo và hướng dẫn

Kho lưu trữ này chứa nội dung được sử dụng để xây dựng .NET bắt đầu các hướng dẫn được lưu trữ tại http://dot.net

## Tổ chức

Nội dung được chia thành các nhóm cấp cao theo chủ đề, ban đầu bao gồm
- [C #] (nội dung / csharp / README.md)
- [ASP.NET] (nội dung / asp.net / README.md)

Trong mỗi khu vực nội dung, có một hoặc nhiều * hướng dẫn *.

Mỗi hướng dẫn bao gồm * bài học *. Mỗi bài học nên là một trang mô tả chi tiết khái niệm được dạy, cùng với mã mẫu. Bài học và trang có thể được sử dụng thay thế cho nhau khi mô tả các hướng dẫn. Bài học có thể được chia thành nhiều bước *. Mỗi bước và bài học nên kết thúc bằng mã làm việc mà người dùng có thể chạy bằng REPL, Visual Studio hoặc Visual Studio Code.

Bạn có thể xem nội dung C # như một mô hình cho các khu vực nội dung khác. Lưu ý rằng URL / liên kết nên sử dụng 'csharp' thay cho C # vì GitHub sẽ chuyển đổi cái sau thành C% 23 dẫn đến liên kết bị hỏng. Cũng lưu ý, các liên kết đến các tệp README.md phân biệt chữ hoa chữ thường trong chế độ xem web của GitHub.

Các bài học sẽ bao gồm * mẹo * sẽ được gắn thẻ theo nền của người đọc và cuối cùng những bài này sẽ được hiển thị cho những người đọc đã cho biết họ có nền đó. Ví dụ:

> ** Mẹo ** {.tip .vb}
> Từ khóa * static * trong C # tương đương với * Shared * trong Visual Basic .NET

Các bài học cũng sẽ bao gồm * ghi chú *, sẽ nhận được định dạng đặc biệt khi hiển thị cho độc giả. Ví dụ:

### Lưu ý {.note}
> Thông thường ghi nhật ký ngoại lệ xảy ra, để bạn có thể xem lại chúng sau và cải thiện chương trình để tránh chúng, nếu có thể.

## Chiến lược phân nhánh

Chi nhánh * master * sẽ chứa nội dung được phê duyệt mới nhất. Trong ngắn hạn, các tác giả nội dung được phê duyệt sẽ được phép đẩy trực tiếp lên chủ. Tuy nhiên, khi có một lượng nội dung đáng kể, các tác giả sẽ được yêu cầu làm việc trong nhánh tính năng của riêng họ trước khi gửi yêu cầu kéo và chờ đợi: shipit: từ một thành viên khác trong nhóm.