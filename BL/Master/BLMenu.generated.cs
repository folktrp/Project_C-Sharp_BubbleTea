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
    public partial class BLMenu : BLBase
    {
        #region Private Methods
        #region Insert
        private List<string> Insert(Menu entity)
        {
            List<string> errorMessage = new List<string>();
            string queryInsert = "INSERT INTO `T_M_MENU` (NAME,IMAGE,PRICE_HOT,PRICE_COOL,PRICE_SPIN,NOTE1,CREATE_DATE,CREATE_USER,UPDATE_DATE,UPDATE_USER) VALUES (";
            queryInsert += "'" + entity.Name + "',";
            queryInsert += "'" + entity.Image + "',";
            queryInsert += "'" + entity.PriceHot + "',";
            queryInsert += "'" + entity.PriceCool + "',";
            queryInsert += "'" + entity.PriceSpin + "',";
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
        private List<string> Update(Menu entity)
        {
            List<string> errorMessage = new List<string>();
            string queryUpdate = "UPDATE `T_M_MENU` SET ";
            queryUpdate += "NAME='" + entity.Name + "',";
            queryUpdate += "IMAGE='" + entity.Image + "',";
            queryUpdate += "PRICE_HOT='" + entity.PriceHot + "',";
            queryUpdate += "PRICE_COOL='" + entity.PriceCool + "',";
            queryUpdate += "PRICE_SPIN='" + entity.PriceSpin + "',";
            queryUpdate += "NOTE1='" + entity.Note1 + "',";
            queryUpdate += "CREATE_DATE='" + Utility.ConvertDateTimeToText(entity.CreateDate) + "',";
            queryUpdate += "CREATE_USER='" + entity.CreateUser + "',";
            queryUpdate += "WHERE " + entity.PK;
            ExecuteNonQuery(queryUpdate);
            return errorMessage;
        }
        #endregion Update
        #region Fill
        private List<Menu> Fill(DataTable dt)
        {
            List<Menu> entityCollection = new List<Menu>();
            Menu entity = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                entity = new Menu();
                if (dt.Rows[i]["ID"] != DBNull.Value)
                {
                    entity.Id = (int)dt.Rows[i]["ID"];
                }
                else
                {
                    entity.Id = 0;
                }
                if (dt.Rows[i]["NAME"] != DBNull.Value)
                {
                    entity.Name = (string)dt.Rows[i]["NAME"];
                }
                else
                {
                    entity.Name = string.Empty;
                }
                if (dt.Rows[i]["IMAGE"] != DBNull.Value)
                {
                    entity.Image = (string)dt.Rows[i]["IMAGE"];
                }
                else
                {
                    entity.Image = string.Empty;
                }
                if (dt.Rows[i]["PRICE_HOT"] != DBNull.Value)
                {
                    entity.PriceHot = (int)dt.Rows[i]["PRICE_HOT"];
                }
                else
                {
                    entity.PriceHot = 0;
                }
                if (dt.Rows[i]["PRICE_COOL"] != DBNull.Value)
                {
                    entity.PriceCool = (int)dt.Rows[i]["PRICE_COOL"];
                }
                else
                {
                    entity.PriceCool = 0;
                }
                if (dt.Rows[i]["PRICE_SPIN"] != DBNull.Value)
                {
                    entity.PriceSpin = (int)dt.Rows[i]["PRICE_SPIN"];
                }
                else
                {
                    entity.PriceSpin = 0;
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
        public List<Menu> Find(string whereClause, string orderBy)
        {
            string queryText = "SELECT * FROM `T_M_MENU` ";
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
        public List<string> Save(List<Menu> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (Menu entity in entityCollection)
            {
                Save(entity);
            }
            return errorMessage;
        }
        public List<string> Save(Menu entity)
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
        public List<string> Delete(List<Menu> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (Menu entity in entityCollection)
            {
                Delete(entity);
            }
            return errorMessage;
        }
        public List<string> Delete(Menu entity)
        {
            List<string> errorMessage = new List<string>();
            string queryText = "DELETE FROM `T_M_MENU` ";
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
                string queryText = "DELETE FROM `T_M_MENU` ";
                queryText += "WHERE " + whereClause;
                ExecuteNonQuery(queryText);
            }
            return errorMessage;
        }
        #endregion DeleteWhere
        #region GetRecord
        public Menu GetRecord(string whereClause)
        {
            List<Menu> entityCollection = Find(whereClause, string.Empty);
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
            string queryText = "SELECT COUNT(*) FROM `T_M_MENU` ";
            queryText += "WHERE " + whereClause;
            DataTable dt = GetDataTable(queryText);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            return result;
        }
        #endregion GetCount
        #region GetPage
        public List<Menu> GetPage(string whereClause, string orderBy, int pageIndex, int pageSize)
        {
            string sql = string.Empty;
            int startIndex = pageSize * pageIndex;
            int endIndex = startIndex + pageSize;
            sql = " SELECT * ,ROW_NUMBER() OVER ( ORDER BY ID)AS INDEX_ROWS FROM `T_M_MENU` WHERE ";
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
