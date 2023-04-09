# Hệ thống đặt thức ăn nhanh:

## Gồm giao diện của 4 phân hệ:
- Đối tác: form quản lý chi nhánh, quản lý thực đơn, quản lý đơn hàng, quản lý hợp đồng.
- Nhân viên: form xử lý hợp đồng.
- Khách hàng: form danh sách món ăn, form danh sách chi nhánh, form đặt hàng.
- Tài xế: form xử lý đơn đặt hàng.

## Các tình huống tranh chấp và sửa lỗi:
- Dirty Read: Khách hàng xem danh sách đơn hàng cùng lúc khi đối tác cập nhật tình trạng đơn 
- Lost update: Khách hàng đặt hàng cùng lúc khi đối tác cập nhật tình trạng đơn hàng
- Unrepeatable read: Đối tác xem danh sách hợp đồng cùng lúc khi nhân viên gia hạn hợp đồng
- Phantom: Khách hàng xem danh sách thực đơn cùng lúc khi đối tác cập nhật thực đơn của quán

## Prerequisites:
- Run 2 file **Database.sql** và **ProcedureList.sql**
- Chỉnh sửa ```connectionString``` trong **App.config** bằng *Server ID hiện tại*
