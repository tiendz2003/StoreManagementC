using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StoreManagement.DAO
{
    class DataProvider
    {
        private static DataProvider instance; // Tạo đối tượng từ khóa là static, suy ra bất cứ cái gì thông qua instance đều là duy nhất

        private string connectionStr = @"Data Source=RONALDO-FOREVER\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        // Hàm thực hiện truy vấn và trả về DataTable
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            string[] listPara = query.Split(' ');
                            int i = 0;
                            foreach (string item in listPara)
                            {
                                if (item.Contains('@'))
                                {
                                    command.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(data);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, có thể ghi log hoặc hiển thị thông báo lỗi
                Console.WriteLine("Error: " + ex.Message);
            }

            return data;
        }

        // Hàm thực hiện lệnh không truy vấn (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            string[] listPara = query.Split(' ');
                            int i = 0;
                            foreach (string item in listPara)
                            {
                                if (item.Contains('@'))
                                {
                                    command.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }

                        data = command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, có thể ghi log hoặc hiển thị thông báo lỗi
                Console.WriteLine("Error: " + ex.Message);
            }

            return data;
        }

        // Hàm thực hiện truy vấn và trả về một giá trị đơn
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            string[] listPara = query.Split(' ');
                            int i = 0;
                            foreach (string item in listPara)
                            {
                                if (item.Contains('@'))
                                {
                                    command.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }

                        data = command.ExecuteScalar();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, có thể ghi log hoặc hiển thị thông báo lỗi
                Console.WriteLine("Error: " + ex.Message);
            }

            return data;
        }
    }
}
