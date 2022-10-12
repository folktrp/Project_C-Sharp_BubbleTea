using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FTPBubbleTea.BL;
using FTPBubbleTea.BC.Security;
using FTPBubbleTea.BC;
namespace FTPBubbleTea.BL.Security
{
    public partial class BLUser : BLBase
    {
        #region Private Methods
        #region Insert
        private List<string> Insert(User entity)
        {
            List<string> errorMessage = new List<string>();
            string queryInsert = "INSERT INTO `T_S_USER` (USER_ID,USER_NAME,PASSWORD,ROLE_ID,LAST_LOGIN_DATE,USER_STATUS,USER_RANK,NOTE1,CREATE_DATE,CREATE_USER,UPDATE_DATE,UPDATE_USER) VALUES (";
            queryInsert += "'" + entity.UserId + "',";
            queryInsert += "'" + entity.UserName + "',";
            queryInsert += "'" + entity.Password + "',";
            queryInsert += "'" + entity.RoleId + "',";
            queryInsert += "'" + Utility.ConvertDateTimeToText(entity.LastLoginDate) + "',";
            queryInsert += "'" + entity.UserStatus + "',";
            queryInsert += "'" + entity.UserRank + "',";
            queryInsert += "'" + entity.Note1 + "',";
            queryInsert += "'" + Utility.ConvertDateTimeToText(entity.CreateDate) + "',";
            queryInsert += "'" + entity.CreateUser + "',";
            queryInsert += "'" + Utility.ConvertDateTimeToText(entity.UpdateDate) + "',";
            queryInsert += "'" + entity.UpdateUser + "')";
            ExecuteNonQuery(queryInsert);
            return errorMessage;
        }
        #endregion Insert
        #region Update
        private List<string> Update(User entity)
        {
            List<string> errorMessage = new List<string>();
            string queryUpdate = "UPDATE `T_S_USER` SET ";
            queryUpdate += "USER_NAME='" + entity.UserName + "',";
            queryUpdate += "PASSWORD='" + entity.Password + "',";
            queryUpdate += "ROLE_ID='" + entity.RoleId + "',";
            queryUpdate += "LAST_LOGIN_DATE='" + Utility.ConvertDateTimeToText(entity.LastLoginDate) + "',";
            queryUpdate += "USER_STATUS='" + entity.UserStatus + "',";
            queryUpdate += "USER_RANK='" + entity.UserRank + "',";
            queryUpdate += "NOTE1='" + entity.Note1 + "',";
            queryUpdate += "CREATE_DATE='" + Utility.ConvertDateTimeToText(entity.CreateDate) + "',";
            queryUpdate += "CREATE_USER='" + entity.CreateUser + "',";
            queryUpdate += "WHERE " + entity.PK;
            ExecuteNonQuery(queryUpdate);
            return errorMessage;
        }
        #endregion Update
        #region Fill
        private List<User> Fill(DataTable dt)
        {
            List<User> entityCollection = new List<User>();
            User entity = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                entity = new User();
                entity.EntityState = EntityBase.EntityStates.Change;
                if (dt.Rows[i]["USER_ID"] != DBNull.Value)
                {
                    entity.UserId = (string)dt.Rows[i]["USER_ID"];
                }
                else
                {
                    entity.UserId = string.Empty;
                }
                if (dt.Rows[i]["USER_NAME"] != DBNull.Value)
                {
                    entity.UserName = (string)dt.Rows[i]["USER_NAME"];
                }
                else
                {
                    entity.UserName = string.Empty;
                }
                if (dt.Rows[i]["PASSWORD"] != DBNull.Value)
                {
                    entity.Password = (string)dt.Rows[i]["PASSWORD"];
                }
                else
                {
                    entity.Password = string.Empty;
                }
                if (dt.Rows[i]["ROLE_ID"] != DBNull.Value)
                {
                    entity.RoleId = Convert.ToInt16(dt.Rows[i]["ROLE_ID"]);
                }
                else
                {
                    entity.RoleId = 0;
                }
                if (dt.Rows[i]["LAST_LOGIN_DATE"] != DBNull.Value)
                {
                    entity.LastLoginDate = (DateTime)dt.Rows[i]["LAST_LOGIN_DATE"];
                }
                else
                {
                    entity.LastLoginDate = DateTime.MinValue;
                }
                if (dt.Rows[i]["USER_STATUS"] != DBNull.Value)
                {
                    entity.UserStatus = Convert.ToInt16(dt.Rows[i]["USER_STATUS"]);
                }
                else
                {
                    entity.UserStatus = 0;
                }
                if (dt.Rows[i]["USER_RANK"] != DBNull.Value)
                {
                    entity.UserRank = Convert.ToInt16(dt.Rows[i]["USER_RANK"]);
                }
                else
                {
                    entity.UserRank = 0;
                }
                if (dt.Rows[i]["NOTE1"] != DBNull.Value)
                {
                    entity.Note1 = (string)dt.Rows[i]["NOTE1"];
                }
                else
                {
                    entity.Note1 = string.Empty;
                }
                if (dt.Rows[i]["CREATE_DATE"] != DBNull.Value)
                {
                    entity.CreateDate = (DateTime)dt.Rows[i]["CREATE_DATE"];
                }
                else
                {
                    entity.CreateDate = DateTime.MinValue;
                }
                if (dt.Rows[i]["CREATE_USER"] != DBNull.Value)
                {
                    entity.CreateUser = (string)dt.Rows[i]["CREATE_USER"];
                }
                else
                {
                    entity.CreateUser = string.Empty;
                }
                if (dt.Rows[i]["UPDATE_DATE"] != DBNull.Value)
                {
                    entity.UpdateDate = (DateTime)dt.Rows[i]["UPDATE_DATE"];
                }
                else
                {
                    entity.UpdateDate = DateTime.MinValue;
                }
                if (dt.Rows[i]["UPDATE_USER"] != DBNull.Value)
                {
                    entity.UpdateUser = (string)dt.Rows[i]["UPDATE_USER"];
                }
                else
                {
                    entity.UpdateUser = string.Empty;
                }
                entityCollection.Add(entity);
            }
            return entityCollection;
        }
        #endregion Fill
        #endregion
        #region Public Methods
        #region Find
        public List<User> Find(string whereClause, string orderBy)
        {
            string queryText = "SELECT * FROM `T_S_USER` ";
            if (!string.IsNullOrEmpty(whereClause))
            {
                queryText += string.Format("WHERE {0}", whereClause);
            }
            if (!string.IsNullOrEmpty(orderBy))
            {
                queryText += string.Format(" ORDER BY {0}", orderBy);
            }
            return Fill(GetDataTable(queryText));
        }
        #endregion Find
        #region Save
        public List<string> Save(List<User> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (User entity in entityCollection)
            {
                Save(entity);
            }
            return errorMessage;
        }
        public List<string> Save(User entity)
        {
            List<string> errorMessage = new List<string>();
            switch (entity.EntityState) //Õ—æ‡¥∑∑ÿ°ø‘≈≈Ïµ“¡§’¬ÏÀ≈—°
            {
                case EntityBase.EntityStates.Added:
                    errorMessage = Insert(entity);
                    break;
                case EntityBase.EntityStates.Change:
                    errorMessage = Update(entity);
                    break;
                case EntityBase.EntityStates.UnChange:
                    break;
            }
            return errorMessage;
        }
        #endregion Save
        #region Delete
        public List<string> Delete(List<User> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (User entity in entityCollection)
            {
                Delete(entity);
            }
            return errorMessage;
        }
        public List<string> Delete(User entity)
        {
            List<string> errorMessage = new List<string>();
            string queryText = "DELETE FROM `T_S_USER` ";
            queryText += "WHERE " + entity.PK;
            ExecuteNonQuery(queryText);
            return errorMessage;
        }
        #endregion Delete
        #region DeleteWhere
        public List<string> DeleteWhere(string whereClause)
        {
            List<string> errorMessage = new List<string>();
            if (!string.IsNullOrEmpty(whereClause))
            {
                string queryText = "DELETE FROM `T_S_USER` ";
                queryText += "WHERE " + whereClause;
                ExecuteNonQuery(queryText);
            }
            return errorMessage;
        }
        #endregion DeleteWhere
        #region GetRecord
        public User GetRecord(string whereClause)
        {
            List<User> entityCollection = Find(whereClause, string.Empty);
            if (entityCollection.Count > 0)
            {
                return entityCollection[0];
            }
            else
            {
                return null;
            }
        }
        #endregion GetRecord
        #region GetCount
        public int GetCount(string whereClause)
        {
            string queryText = "SELECT COUNT(*) FROM `T_S_USER` ";
            queryText += "WHERE " + whereClause;
            DataTable dt = GetDataTable(queryText);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            return result;
        }
        #endregion GetCount
        #region GetPage
        public List<User> GetPage(string whereClause, string orderBy, int pageIndex, int pageSize)
        {
            string sql = string.Empty;
            int startIndex = pageSize * pageIndex;
            int endIndex = startIndex + pageSize;
            sql = " SELECT * ,ROW_NUMBER() OVER ( ORDER BY USER_ID)AS INDEX_ROWS FROM `T_S_USER` WHERE ";
            sql += whereClause;
            string sqlExecute = string.Empty;
            sqlExecute = "SELECT * FROM (" + sql + ") AS A";
            sqlExecute += " WHERE INDEX_ROWS  > " + startIndex;
            sqlExecute += " AND INDEX_ROWS  <= " + endIndex;
            return Fill(GetDataTable(sqlExecute));
        }
        #endregion GetPage
        #endregion Public Methods
    }
}
