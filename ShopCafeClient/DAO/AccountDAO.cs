using Demo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCafeClient.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        private SqlDataAccessHelper dbHelper;

        public AccountDAO()
        {
            dbHelper = new SqlDataAccessHelper();
        }
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO();
            return instance; }
            private set { instance = value; }
        }

        public bool CheckLogin(string Username, string Password)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + Username + "' AND PassWord = N'" + Password + "' ";
            DataTable result = SqlDataAccessHelper.ExecuteQuery(query);
            
            return result.Rows.Count > 0;
        }
    }
}
