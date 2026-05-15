1. Lớp cấu hình Database (KetNoiDB.cs)
using System;
using System.Data.SqlClient; // Thư viện để làm việc với SQL Server (ADO.NET)

namespace DuAnBanKet
{
    public class KetNoiDB
    {
        // Khai báo một chuỗi kết nối (Connection String)
        // LƯU Ý: Bạn CẦN THAY ĐỔI "Data Source=..." thành tên Server SQL của máy bạn.
        // Chuỗi này cho biết: Kết nối đến server nào, database nào, và dùng quyền Windows (Integrated Security).
        public static string chuoiKetNoi = @"Data Source=TÊN_MÁY_CỦA_BẠN\SQLEXPRESS;Initial Catalog=DuAnBanKetDB;Integrated Security=True";

        // Hàm này dùng để trả về một đối tượng SqlConnection đã sẵn sàng
        public static SqlConnection LayKetNoi()
        {
            // Tạo một đối tượng kết nối mới sử dụng chuỗi kết nối ở trên
            return new SqlConnection(chuoiKetNoi);
        }
    }
}