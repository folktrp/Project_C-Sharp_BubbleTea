
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FTPBubbleTea.BL
{
    public class BLBase
    {

        #region Fields

        private string _connectionString = string.Empty;

        #endregion 

        #region Constructor

        public BLBase()
        {
            string server = ConfigurationManager.AppSettings["Server"];
            string database = ConfigurationManager.AppSettings["Database"];
            string username = ConfigurationManager.AppSettings["Username"];
            string password = ConfigurationManager.AppSettings["Password"];
            _connectionString = string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};", server, database, username, password);
        }

        #endregion

        #region Public Methods

        #region GetDataTable

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryText"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string queryText)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand(queryText, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception)
            {


            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                cmd.Dispose();
            }


            return dt;
        }

        #endregion

        #region ExecuteNonQuery

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryText"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string queryText)
        {

            MySqlConnection con = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand(queryText, con);
            int result = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {


            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                cmd.Dispose();
            }
            return result;
        }

        #endregion

        #endregion

    }
}
