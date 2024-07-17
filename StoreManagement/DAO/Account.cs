using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO
{
    internal class Account
    {

        private static Account instance;

        public static Account Instance
        {
            get
            {
                if (instance == null) ;
                instance = new Account();
                return Account.instance;
            }

            private set { Account.instance = value; }
        }

        public bool DN(string usename, string password)
        {
            string query = "select * from DangNhap where TaiKhoan =('" + usename + "') and password = ('" + password + "') ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { usename, password });
            return result.Rows.Count > 0;  //tra ve gia tri >0 
        }

    }
}
