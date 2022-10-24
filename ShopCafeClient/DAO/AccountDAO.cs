using Cafee;
using Demo;
using ShopCafeClient.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopCafeClient.DAO
{
    public class AccountDAO
    {
        String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        private static AccountDAO instance;

        private AccountDAO(){}
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public bool CheckLogin(string Username, string Password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(Password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string haspass = "";
            foreach(byte b in hasData)
            {
                haspass += b;
            }

            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + Username + "' AND PassWord = N'" + Password + "' ";

            DataTable kq = DataProvider.Instance.ExecuteQuery(query);

            return kq.Rows.Count > 0;
        }

        public List<Account> SelectAll()
        {
            List<Account> list = new List<Account>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT id,Username,DisplayName,type  FROM dbo.Account";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Account account = new Account()
                {
                    id = (int)dr["ID"],
                    Username = (string)dr["Username"],
                    DisplayName = (string)dr["DisplayName"],
                    type = (int)dr["type"],
                };
                list.Add(account);
            }
            con.Close();
            return list;
        }

        public List<Account> SelectByKeyWord(string keyword)
        {
            List<Account> list = new List<Account>();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT id,Username,DisplayName,type FROM dbo.Account WHERE Username LIKE @KeyWord";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@KeyWord", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Account item = new Account()
                {
                    id = (int)dr["ID"],
                    Username = (string)dr["Username"],
                    DisplayName = (string)dr["DisplayName"],
                    type = (int)dr["type"],
                };
                list.Add(item);
            }
            return list;

        }

        public Account SelectedByCode(int id)
        {
            Account account = null;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT id,Username,DisplayName,type FROM dbo.Account where id=@id";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                account = new Account()
                {
                    id = (int)dr["ID"],
                    Username = (string)dr["Username"],
                    DisplayName = (string)dr["DisplayName"],
                    type = (int)dr["type"],
                };
            }
            return account;
        }

        public bool Insert(Account newAccount)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "INSERT INTO dbo.Account(Username,DisplayName,type) VALUES(@Username,@DisplayName,@type)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Username", newAccount.Username));
            com.Parameters.Add(new SqlParameter("@DisplayName", newAccount.DisplayName));
            com.Parameters.Add(new SqlParameter("@type", newAccount.type));
            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public bool Update(Account newAccount)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "UPDATE dbo.Account SET Username=@Username DisplayName=@DisplayName,type=@type where id=@id";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@id", newAccount.id));
            com.Parameters.Add(new SqlParameter("@Username", newAccount.Username));
            com.Parameters.Add(new SqlParameter("@DisplayName", newAccount.DisplayName));
            com.Parameters.Add(new SqlParameter("@type", newAccount.type));

            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;

        }

        public bool Delete(int id)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "DELETE FROM dbo.Account where id=@id";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@id", id));
            try
            {
                result = com.ExecuteNonQuery() > 0;
            }
            catch
            {
                result = false;
            }
            con.Close();
            return result;
        }
    }
}
