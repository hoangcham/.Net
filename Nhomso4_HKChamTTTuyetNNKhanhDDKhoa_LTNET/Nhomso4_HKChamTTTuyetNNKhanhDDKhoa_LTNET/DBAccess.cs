using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhomso4_HKChamTTTuyetNNKhanhDDKhoa_LTNET
{
    internal class DBAccess
    {
        SqlConnection con;
        //Viết phương thức mở cơ sở dữ liệu
        public void MoCSDL()
        {
            string diachi = @"Data Source=DESKTOP-8LMO6HU\KIMCHAM;Initial Catalog=QLKhachSan;Integrated Security=True; ";
            con = new SqlConnection(diachi);
            con.Open();
        }

        //đóng CSDL
        public void DongCSDL()
        {
            con.Close();
        }

        // Phương thức trả về kết nối, nếu cần truy cập kết nối từ nơi khác
        public SqlConnection GetConnection()
        {
            return con;
        }

        #region Phần Đăng nhập, đổi mật khẩu - Châm
        // Kiểm tra thông tin đăng nhập và lấy vai trò
        public string KiemTraTTDN(string username, string password)
        {
            string loaiNguoiDung = null;

            try
            {
                MoCSDL(); // Mở kết nối

                // Truy vấn để kiểm tra tài khoản và lấy vai trò LoaiNguoiDung
                string query = "SELECT LoaiNguoiDung FROM NhanVien WHERE HoTen=@username AND MatKhau=@password";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); // Thay mật khẩu nếu cần

                    var result = command.ExecuteScalar();

                    if (result != null) // Nếu có kết quả, lấy LoaiNguoiDung
                    {
                        loaiNguoiDung = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                DongCSDL(); // Đảm bảo đóng kết nối
            }

            return loaiNguoiDung; // Trả về vai trò nếu thành công, nếu không thì trả về null
        }

        public bool DoiMatKhau(string username, string newPassword)
        {
            bool isUpdated = false; // Biến để theo dõi trạng thái cập nhật
            string query = "UPDATE NhanVien SET MatKhau = @password WHERE HoTen = @username";

            try
            {
                MoCSDL(); // Mở kết nối

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Thêm tham số cho truy vấn
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@username", username);

                    // Thực thi truy vấn
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có dòng nào được cập nhật không
                    isUpdated = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                DongCSDL(); // Đóng kết nối
            }

            return isUpdated; // Trả về trạng thái
        }

        #endregion

        #region Phần Quản lý nhân viên - Châm
        public DataTable TraDanhSachNV()
        {
            MoCSDL();
            string sql = "SELECT * FROM NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt); //chuyển toàn bộ dữ liệu của da sang dt
            DongCSDL();
            return dt;
        }

        //Viết phương thức trùng mã nhân viên
        public bool KiemTraMaNV(string ma)
        {
            MoCSDL();
            string sql = "SELECT * FROM NhanVien WHERE MaNhanVien = '" + ma + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false; //không trùng
            }

        }

        //Viết phương thức thêm mới một nhân viên
        public bool ThemNV(Class_NhanVien_Cham nv)
        {
            if (KiemTraMaNV(nv.MaNV) == true)
            {

                return true;
            }
            else
            {
                MoCSDL();
                string sql = "INSERT INTO NhanVien VALUES(@ma, @ht, @ns, @gt, @mk, @lnd)";
                SqlCommand cmd = new SqlCommand(sql, con);
                //truyền giá trị cho tham số
                cmd.Parameters.AddWithValue("ma", nv.MaNV);
                cmd.Parameters.AddWithValue("ht", nv.HotenNV);
                cmd.Parameters.AddWithValue("ns", nv.NgaySinh);
                cmd.Parameters.AddWithValue("gt", nv.GioiTinh);
                cmd.Parameters.AddWithValue("mk", nv.MatKhau);
                cmd.Parameters.AddWithValue("lnd", nv.LoaiNguoiDung);
                cmd.ExecuteNonQuery();
                return false;
            }
        }

        public void SuaNV(Class_NhanVien_Cham nv)
        {
            // Mở kết nối đến CSDL
            MoCSDL();
            string query = "UPDATE NhanVien SET HoTen = @TenNV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, MatKhau = @MatKhau, LoaiNguoiDung = @LoaiNguoiDung WHERE MaNhanVien = @MaNV";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@TenNV", nv.HotenNV);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
                cmd.Parameters.AddWithValue("@LoaiNguoiDung", nv.LoaiNguoiDung);
                // Thực thi câu lệnh SQL
                cmd.ExecuteNonQuery();
            }
            // Đóng kết nối sau khi thực hiện
            DongCSDL();
        }

        public void XoaNV(string MaNV)
        {
            MoCSDL();
            string sql = "delete from NhanVien where MaNhanVien=@Ma ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("Ma", MaNV);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }

        public DataTable TimKiemTheoTenNV(string ten)
        {
            MoCSDL();
            string sql = "SELECT * FROM NhanVien WHERE HoTen LIKE @ten";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", "%" + ten + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            return dt;
        }

        #endregion

        #region Phần Quản lí phòng - Tuyết
        public DataTable TraDanhSachPhong()
        {
            MoCSDL();
            string sql = "SELECT * FROM Phong";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt); // Chuyển dữ liệu từ `da` vào `dt`
            DongCSDL();
            return dt;
        }
        public bool KiemTraMaPhong(string maPhong)
        {
            MoCSDL();
            string sql = "SELECT * FROM Phong WHERE MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            return dt.Rows.Count > 0; // Nếu tồn tại trả về true
        }
        public bool ThemPhong(Class_Phong_Tuyet phong)
        {
            if (KiemTraMaPhong(phong.MaPhong))
            {
                return true; // Phòng đã tồn tại
            }
            else
            {
                MoCSDL();
                string sql = "INSERT INTO Phong (MaPhong, TenPhong, MaLoaiPhong, TinhTrang) VALUES (@MaPhong, @TenPhong, @MaLoaiPhong, @TinhTrang)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaPhong", phong.MaPhong);
                cmd.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
                cmd.Parameters.AddWithValue("@MaLoaiPhong", phong.MaLoaiPhong);
                cmd.Parameters.AddWithValue("@TinhTrang", phong.TinhTrang);
                cmd.ExecuteNonQuery();
                DongCSDL();
                return false; // Thêm thành công
            }
        }
        public void SuaPhong(Class_Phong_Tuyet phong)
        {
            MoCSDL();
            string sql = "UPDATE Phong SET TenPhong = @TenPhong, MaLoaiPhong = @MaLoaiPhong, TinhTrang = @TinhTrang WHERE MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MaPhong", phong.MaPhong);
            cmd.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
            cmd.Parameters.AddWithValue("@MaLoaiPhong", phong.MaLoaiPhong);
            cmd.Parameters.AddWithValue("@TinhTrang", phong.TinhTrang);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }
        public void XoaPhong(string maPhong)
        {
            MoCSDL();
            string sql = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }
        public DataTable TimKiemPhongTheoTen(string tenPhong)
        {
            MoCSDL();
            string sql = "SELECT * FROM Phong WHERE TenPhong LIKE @TenPhong";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@TenPhong", "%" + tenPhong + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            return dt;
        }
        #endregion

        #region Phần Quản lý khách hàng - Tuyết
        //Viết phương thức trả về toàn bộ dữ liệu bảng khách hàng
        public DataTable TraDanhSachKH()
        {
            MoCSDL();
            string sql = "SELECT * FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt); //chuyển toàn bộ dữ liệu của da sang dt
            DongCSDL();
            return dt;
        }

        //Viết phương thức trùng mã khách hàng
        public bool KiemTraMaKH(string ma)
        {
            MoCSDL();
            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang = '" + ma + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false; //không trùng
            }

        }

        //Viết phương thức thêm mới một khách hàng
        public bool ThemKH(Class_KhachHang_Tuyet kh)
        {
            if (KiemTraMaKH(kh.MaKH) == true)
            {

                return true;
            }
            else
            {
                MoCSDL();
                string sql = "INSERT INTO KhachHang VALUES(@ma, @ht, @scmt, @qt, @gt, @sdt)";
                SqlCommand cmd = new SqlCommand(sql, con);
                //truyền giá trị cho tham số
                cmd.Parameters.AddWithValue("ma", kh.MaKH);
                cmd.Parameters.AddWithValue("ht", kh.HotenKH);
                cmd.Parameters.AddWithValue("scmt", kh.SoCMT);
                cmd.Parameters.AddWithValue("qt", kh.QuocTich);
                cmd.Parameters.AddWithValue("gt", kh.GioiTinh);
                cmd.Parameters.AddWithValue("sdt", kh.SoDT);
                cmd.ExecuteNonQuery();
                return false;
            }
        }

        public void SuaKH(Class_KhachHang_Tuyet kh)
        {
            // Mở kết nối đến CSDL
            MoCSDL();
            // Câu lệnh SQL để cập nhật thông tin khách hàng
            string query = "UPDATE KhachHang SET TenKhachHang = @TenKH,SoChungMinhThu = @SoCMT, QuocTich = @QuocTich, Gioitinh = @GioiTinh, SoDienThoai = @SDT WHERE MaKhachHang = @MaKH";
            // Thiết lập các tham số và thực thi câu lệnh
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.HotenKH);
                cmd.Parameters.AddWithValue("@SoCMT", kh.SoCMT);
                cmd.Parameters.AddWithValue("@QuocTich", kh.QuocTich);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@SDT", kh.SoDT);
                // Thực thi câu lệnh SQL
                cmd.ExecuteNonQuery();
            }
            // Đóng kết nối sau khi thực hiện
            DongCSDL();
        }

        public void XoaKH(string MaKH)
        {
            MoCSDL();
            string sql = "delete from KhachHang where MaKhachHang = @Ma    ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("Ma", MaKH);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }

        public DataTable TimKiemTheoTenKH(string ten)
        {
            MoCSDL();
            string sql = "SELECT * FROM KhachHang WHERE TenKhachHang LIKE @ten";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", "%" + ten + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            return dt;
        }

        #endregion



        #region Phần Quản lý dịch vụ - Châm
        public DataTable TraDanhSachDV()
        {
            MoCSDL();
            string sql = "SELECT * FROM DichVu";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt); //chuyển toàn bộ dữ liệu của da sang dt
            DongCSDL();
            return dt;
        }

        //Viết phương thức trùng mã dich vụ
        public bool KiemTraMaDV(string ma)
        {
            MoCSDL();
            string sql = "SELECT * FROM DichVu WHERE MaDichVu = '" + ma + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false; //không trùng
            }

        }

        //Viết phương thức thêm mới một dịch vụ
        public bool ThemDV(Class_DichVu_Cham dv)
        {
            if (KiemTraMaDV(dv.MaDV) == true)
            {

                return true;
            }
            else
            {
                MoCSDL();
                string sql = "INSERT INTO DichVu VALUES(@ma, @ten, @gia)";
                SqlCommand cmd = new SqlCommand(sql, con);
                //truyền giá trị cho tham số
                cmd.Parameters.AddWithValue("ma", dv.MaDV);
                cmd.Parameters.AddWithValue("ten", dv.TenDV);
                cmd.Parameters.AddWithValue("gia", dv.GiaDV);
                cmd.ExecuteNonQuery();
                return false;
            }
        }

        public void SuaDV(Class_DichVu_Cham dv)
        {
            // Mở kết nối đến CSDL
            MoCSDL();
            string query = "UPDATE DichVu SET TenDichVu = @Ten, GiaDichVu = @Gia WHERE MaDichVu = @Ma";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Ma", dv.MaDV);
                cmd.Parameters.AddWithValue("@Ten", dv.TenDV);
                cmd.Parameters.AddWithValue("@Gia", dv.GiaDV);
                // Thực thi câu lệnh SQL
                cmd.ExecuteNonQuery();
            }
            // Đóng kết nối sau khi thực hiện
            DongCSDL();
        }

        public void XoaDV(string MaDV)
        {
            MoCSDL();
            string sql = "delete from DichVu where MaDichVu=@Ma ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("Ma", MaDV);
            cmd.ExecuteNonQuery();
            DongCSDL();
        }

        public DataTable TimKiemTheoTenDV(string ten)
        {
            MoCSDL();
            string sql = "SELECT * FROM DichVu WHERE TenDichVu LIKE @ten";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", "%" + ten + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DongCSDL();
            return dt;
        }
        #endregion


        
    }
}
