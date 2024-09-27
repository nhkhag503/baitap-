using System;

namespace khnag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isRunning = true;

            while (isRunning)
            {
                // Hiển thị menu
                Console.WriteLine("Chọn bài tập từ 1 đến 6:");
                Console.WriteLine("1. Tính tổng hai số");
                Console.WriteLine("2. Tính hình chữ nhật");
                Console.WriteLine("3. Tính hình tròn");
                Console.WriteLine("4. Thông tin học sinh");
                Console.WriteLine("5. Thông tin nhân viên");
                Console.WriteLine("6. Nhập ngày tháng năm");
                Console.WriteLine("0. Thoát");

                // Nhận lựa chọn từ người dùng
                Console.Write("Nhập lựa chọn của bạn: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        TinhTongHaiSo();
                        break;
                    case "2":
                        TinhHinhChuNhat();
                        break;
                    case "3":
                        TinhHinhTron();
                        break;
                    case "4":
                        ThongTinHocsinh();
                        break;
                    case "5":
                        ThongTinNhanVien();
                        break;
                    case "6":
                        NhapNgayThangNam();
                        break;
                    case "0":
                        isRunning = false; // Thoát khỏi vòng lặp
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine(); // Tạo khoảng trống giữa các lần lặp
            }
        }

        private static void TinhTongHaiSo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập vào số nguyên a: ");
            int SoNguyenA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập vào số nguyên b: ");
            int SoNguyenB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tổng A + B là: {0}", SoNguyenA + SoNguyenB);
            Console.WriteLine("Nhấn Enter để tiếp tục...");
            Console.ReadLine();
        }

        private static void TinhHinhChuNhat()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a, b;

            Console.WriteLine("Nhập cạnh a: ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương cho cạnh a.");
            }

            Console.WriteLine("Nhập cạnh b: ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương cho cạnh b.");
            }

            int chuvi = 2 * (a + b);
            int dienTich = a * b;

            Console.WriteLine("Chu vi = " + chuvi);
            Console.WriteLine("Diện tích = " + dienTich);
            Console.WriteLine("Nhấn Enter để tiếp tục...");
            Console.ReadLine();
        }

        private static void TinhHinhTron()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập vào đường kính hình tròn: ");
            double duongKinh = Convert.ToDouble(Console.ReadLine());

            double banKinh = duongKinh / 2;
            double chuVi = 2 * Math.PI * banKinh;
            double dienTich = Math.PI * banKinh * banKinh;

            Console.WriteLine($"Bán kính: {banKinh}");
            Console.WriteLine($"Chu vi: {chuVi}");
            Console.WriteLine($"Diện tích: {dienTich}");
            Console.WriteLine("Nhấn Enter để tiếp tục...");
            Console.ReadLine();
        }

        private static void ThongTinHocsinh()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Nhập họ tên của bạn: ");
            string hoten = Console.ReadLine();

            Console.WriteLine("Nhập lớp của bạn: ");
            string lop = Console.ReadLine();

            double diemtbHK1;
            while (true)
            {
                Console.WriteLine("Nhập điểm trung bình HKI: ");
                if (double.TryParse(Console.ReadLine(), out diemtbHK1) && diemtbHK1 >= 0)
                    break;
                Console.WriteLine("Vui lòng nhập một số thực không âm cho điểm trung bình HKI.");
            }

            double diemtbHK2;
            while (true)
            {
                Console.WriteLine("Nhập điểm trung bình HKII: ");
                if (double.TryParse(Console.ReadLine(), out diemtbHK2) && diemtbHK2 >= 0)
                    break;
                Console.WriteLine("Vui lòng nhập một số thực không âm cho điểm trung bình HKII.");
            }

            double diemTBNam = (diemtbHK1 + diemtbHK2 * 2) / 3;
            Console.WriteLine($"Điểm trung bình cả năm của {hoten} lớp {lop} là: {diemTBNam:F2}");
            Console.WriteLine("Nhấn Enter để tiếp tục...");
            Console.ReadLine();
        }

        private static void ThongTinNhanVien()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Nhập họ tên nhân viên: ");
            string hoten_nv = Console.ReadLine();
            
            Console.WriteLine("Nhập giới tính:");
            string gioitinh = Console.ReadLine();
            
            Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy):");
            string ngaysinh = Console.ReadLine();
            
            double heso_luong;
            while (!double.TryParse(Console.ReadLine(), out heso_luong) || heso_luong < 0)
            {
                Console.WriteLine("Vui lòng nhập một số thực không âm cho hệ số lương.");
            }
            
            int luong_cb;
            while (true)
            {
                Console.WriteLine("Lương cơ bản:");
                if (int.TryParse(Console.ReadLine(), out luong_cb) && luong_cb > 0)
                    break;
                Console.WriteLine("Vui lòng nhập một số nguyên dương cho lương cơ bản.");
            }

            int so_nam_lam;
            while (true)
            {
                Console.WriteLine("Số năm làm việc:");
                if (int.TryParse(Console.ReadLine(), out so_nam_lam) && so_nam_lam >= 0)
                    break;
                Console.WriteLine("Vui lòng nhập một số nguyên không âm cho số năm làm việc.");
            }

            double phucap = 0;
            if (so_nam_lam > 5)
            {
                phucap = 0.5 * luong_cb;
            }

            double luong_thang = heso_luong * luong_cb + phucap;

            Console.WriteLine("\n--- Thông tin nhân viên ---");
            Console.WriteLine($"Họ tên: {hoten_nv}");
            Console.WriteLine($"Giới tính: {gioitinh}");
            Console.WriteLine($"Ngày sinh: {ngaysinh}");
            Console.WriteLine($"Hệ số lương: {heso_luong}");
            Console.WriteLine($"Lương cơ bản: {luong_cb}");
            Console.WriteLine($"Số năm làm việc: {so_nam_lam}");
            Console.WriteLine($"Phụ cấp: {phucap}");
            Console.WriteLine($"Lương tháng: {luong_thang}");
            Console.WriteLine("Nhấn Enter để tiếp tục...");
            Console.ReadLine();
        }

        private static void NhapNgayThangNam()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Nhập ngày (dd): ");
                int ngay = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tháng (MM): ");
                int thang = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhập năm (yyyy): ");
                int nam = int.Parse(Console.ReadLine());

                // Kiểm tra tính hợp lệ của ngày
                DateTime ngayNhap = new DateTime(nam, thang, ngay);

                // Tính ngày hôm qua và ngày mai
                DateTime ngayHomQua = ngayNhap.AddDays(-1);
                DateTime ngayMai = ngayNhap.AddDays(1);

                // Hiển thị kết quả
                Console.WriteLine($"Ngày hôm qua: {ngayHomQua.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Ngày mai: {ngayMai.ToString("dd/MM/yyyy")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            Console.WriteLine("Nhấn Enter để tiếp tục...");
            Console.ReadLine();
        }
    }
}

