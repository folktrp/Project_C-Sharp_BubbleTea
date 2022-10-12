// Generate User teerapat
// Generate Date 23/6/2022 20:17:26
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FTPBubbleTea.BL;
using FTPBubbleTea.BC.Master;
using FTPBubbleTea.BC;
namespace FTPBubbleTea.BL.Master
{
    public partial class BLMember : BLBase
    {
        #region Private Methods
        #region Insert
        private List<string> Insert(Member entity)
        {
            List<string> errorMessage = new List<string>();
            string queryInsert = "INSERT INTO `T_M_MEMBER` (ID,TEL,NAME,SURNAME,NICK_NAME,CREATE_DATE,CREATE_USER,UPDATE_DATE,UPDATE_USER) VALUES (";
            queryInsert += "'" + entity.Id + "',";
            queryInsert += "'" + entity.Tel + "',";
            queryInsert += "'" + entity.Name + "',";
            queryInsert += "'" + entity.Surname + "',";
            queryInsert += "'" + entity.NickName + "',";
            queryInsert += "'" + Utility.ConvertDateTimeToText(entity.CreateDate) + "',";
            queryInsert += "'" + entity.CreateUser + "',";
            queryInsert += "'" + Utility.ConvertDateTimeToText(entity.UpdateDate) + "',";
            queryInsert += "'" + entity.UpdateUser + "')";
            ExecuteNonQuery(queryInsert);
            return errorMessage;
        }
        #endregion Insert
        #region Update
        private List<string> Update(Member entity)
        {
            List<string> errorMessage = new List<string>();
            string queryUpdate = "UPDATE `T_M_MEMBER` SET ";
            queryUpdate += "TEL='" + entity.Tel + "',";
            queryUpdate += "NAME='" + entity.Name + "',";
            queryUpdate += "SURNAME='" + entity.Surname + "',";
            queryUpdate += "NICK_NAME='" + entity.NickName + "',";
            queryUpdate += "CREATE_DATE='" + Utility.ConvertDateTimeToText(entity.CreateDate) + "',";
            queryUpdate += "CREATE_USER='" + entity.CreateUser + "',";
            queryUpdate += "UPDATE_DATE='" + Utility.ConvertDateTimeToText(entity.UpdateDate) + "',";
            queryUpdate += "UPDATE_USER='" + entity.UpdateUser + "'";
            queryUpdate += "WHERE " + entity.PK;
            ExecuteNonQuery(queryUpdate);
            return errorMessage;
        }
        #endregion Update
        #region Fill
        private List<Member> Fill(DataTable dt)
        {
            List<Member> entityCollection = new List<Member>();
            Member entity = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                entity = new Member();
                if (dt.Rows[i]["ID"] != DBNull.Value)
                {
                    entity.Id = (int)dt.Rows[i]["ID"];
                }
                else
                {
                    entity.Id = 0;
                }
                if (dt.Rows[i]["TEL"] != DBNull.Value)
                {
                    entity.Tel = (string)dt.Rows[i]["TEL"];
                }
                else
                {
                    entity.Tel = string.Empty;
                }
                if (dt.Rows[i]["NAME"] != DBNull.Value)
                {
                    entity.Name = (string)dt.Rows[i]["NAME"];
                }
                else
                {
                    entity.Name = string.Empty;
                }
                if (dt.Rows[i]["SURNAME"] != DBNull.Value)
                {
                    entity.Surname = (string)dt.Rows[i]["SURNAME"];
                }
                else
                {
                    entity.Surname = string.Empty;
                }
                if (dt.Rows[i]["NICK_NAME"] != DBNull.Value)
                {
                    entity.NickName = (string)dt.Rows[i]["NICK_NAME"];
                }
                else
                {
                    entity.NickName = string.Empty;
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
        public List<Member> Find(string whereClause, string orderBy)
        {
            string queryText = "SELECT * FROM `T_M_MEMBER` ";
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
        public List<string> Save(List<Member> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (Member entity in entityCollection)
            {
                Save(entity);
            }
            return errorMessage;
        }
        public List<string> Save(Member entity)
        {
            List<string> errorMessage = new List<string>();
            switch (entity.EntityState)
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
        public List<string> Delete(List<Member> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (Member entity in entityCollection)
            {
                Delete(entity);
            }
            return errorMessage;
        }
        public List<string> Delete(Member entity)
        {
            List<string> errorMessage = new List<string>();
            string queryText = "DELETE FROM `T_M_MEMBER` ";
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
                string queryText = "DELETE FROM `T_M_MEMBER` ";
                queryText += "WHERE " + whereClause;
                ExecuteNonQuery(queryText);
            }
            return errorMessage;
        }
        #endregion DeleteWhere
        #region GetRecord
        public Member GetRecord(string whereClause)
        {
            List<Member> entityCollection = Find(whereClause, string.Empty);
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
            string queryText = "SELECT COUNT(*) FROM `T_M_MEMBER` ";
            queryText += "WHERE " + whereClause;
            DataTable dt = GetDataTable(queryText);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            return result;
        }
        #endregion GetCount
        #region GetPage
        public List<Member> GetPage(string whereClause, string orderBy, int pageIndex, int pageSize)
        {
            string sql = string.Empty;
            int startIndex = pageSize * pageIndex;
            int endIndex = startIndex + pageSize;
            sql = " SELECT * ,ROW_NUMBER() OVER ( ORDER BY ID)AS INDEX_ROWS FROM `T_M_MEMBER` WHERE ";
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
