﻿using ShopCafeClient.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafee
{
    internal class DataProvider
    {
        private String strCon = @"Data Source=LAPTOP-0SK7S71J\QUYSQLSERVER;Initial Catalog=QuanLyQuanCaFe;User ID=sa;Password=1";
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get{
                if (instance == null) instance = new DataProvider();
                    return DataProvider.instance;
            }
            private set { instance = value; }
        }

        private DataProvider() {
            strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable datatable = new DataTable();

            using (SqlConnection sqlconnection = new SqlConnection(strCon))
            {
                sqlconnection.Open();
                SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlcommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcommand);
                adapter.Fill(datatable);
                sqlconnection.Close();
            }
            return datatable;
        }

        public bool ExecuteNonQurey(string query, object[] parameter = null)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                try
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
                    ;
                    result = command.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
                connection.Close();
            }
            return result;
        }
    }
}
