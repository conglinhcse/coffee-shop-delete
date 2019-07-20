using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private DataProvider(){}

        private readonly string connectionSTR = @"Data Source=DRAGON;Initial Catalog=CoffeeShop;Integrated Security=True";

        

        // Hàm thực thực thi câu truy vấn
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            // Tạo bản dữ liệu(Data table) chứa dữ liệu trả về
            DataTable data = new DataTable();

            // Tạo 1 kết nối(connection) xuống cơ sở dữ liệu(database) CoffeeShop
            // Từ khóa using để đảm bảo connection được đóng sau khi ExcuteQuery
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối
                connection.Open();
                // Tạo command thực thi(excute) câu truy vấn(query)
                SqlCommand command = new SqlCommand(query, connection);
                // Truyền đối số cho command (nếu có)
                if (parameter != null)
                {
                    // Tìm tham số của thủ tục(procedure)
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                        // Truyền đối số cho command 
                        if (item.Contains('@'))
                            command.Parameters.AddWithValue(item, parameter[i++]);
                }
                // Tạo bộ chuyển đổi(Adapter) thực thi command
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                // Đổ dữ liệu vào bảng
                adapter.Fill(data);
                // Đóng kết nối
                connection.Close();
            }

            // Return bảng dữ liệu(data table)
            return data;
        }
        // Hàm trả về số dòng thành công khi ExcuteQuery
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            // Tạo biến integer chứa số dòng thành công
            int data = 0;

            // Tạo 1 kết nối(connection) xuống cơ sở dữ liệu(database) CoffeeShop
            // Từ khóa using để đảm bảo connection được đóng sau khi ExcuteQuery
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối
                connection.Open();
                // Tạo command thực thi(excute) câu truy vấn(query)
                SqlCommand command = new SqlCommand(query, connection);
                // Truyền đối số cho command (nếu có)
                if (parameter != null)
                {
                    // Tìm tham số của thủ tục(procedure)
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                        // Truyền đối số cho command 
                        if (item.Contains('@'))
                            command.Parameters.AddWithValue(item, parameter[i++]);
                }
                // Tính số dòng thành công
                data = command.ExecuteNonQuery();
                // Đóng kết nối
                connection.Close();
            }

            // Return bảng dữ liệu(data table)
            return data;
        }
        // Hàm trả ô đầu tiên
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            // Tạo biến integer chứa số dòng thành công
            object data = 0;

            // Tạo 1 kết nối(connection) xuống cơ sở dữ liệu(database) CoffeeShop
            // Từ khóa using để đảm bảo connection được đóng sau khi ExcuteQuery
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối
                connection.Open();
                // Tạo command thực thi(execute) câu truy vấn(query)
                SqlCommand command = new SqlCommand(query, connection);
                // Truyền đối số cho command (nếu có)
                if (parameter != null)
                {
                    // Tìm tham số của thủ tục(procedure)
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string item in listPara)
                        // Truyền đối số cho command 
                        if (item.Contains('@'))
                            command.Parameters.AddWithValue(item, parameter[i++]);
                }
                // Tính số dòng thành công
                data = command.ExecuteScalar();
                // Đóng kết nối
                connection.Close();
            }

            // Return bảng dữ liệu(data table)
            return data;
        }
    }
}
