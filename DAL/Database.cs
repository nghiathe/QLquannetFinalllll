﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        //SQL Connection
        public class SqlConnectionData
        {
            public static SqlConnection Connect()
            {
                string Strconn = "Data Source=DESKTOP-N234E7R\\SQLEXPRESS01;Initial Catalog=QuanNet;Integrated Security=True;Encrypt=True";
                SqlConnection conn = new SqlConnection(Strconn);
                return conn;
            }
        }

        #region ---------- Code cua HungTuLenh 
        private static Database instance;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return Database.instance;
            }
            private set { Database.instance = value; }
        }

        private string connectionSTR = "Data Source=LAPTOP-KKNF42CS\\SQLEXPRESS;Initial Catalog = QLyCafeInternet; Integrated Security = True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(query, cn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                cn.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(query, cn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cm.ExecuteNonQuery();
                cn.Close();
            }
            return dt;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dt = 0;
            using (SqlConnection cn = new SqlConnection(connectionSTR))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(query, cn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cm.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                dt = cm.ExecuteScalar();
                cn.Close();
            }
            return dt;
        }
        #endregion
    }
}
