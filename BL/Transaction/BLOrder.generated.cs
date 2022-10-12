// Generate User teerapat
// Generate Date 21/6/2022 13:42:25
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FTPBubbleTea.BL;
using FTPBubbleTea.BC.Transaction;
using FTPBubbleTea.BC;
namespace FTPBubbleTea.BL.Transaction
{
    public partial class BLOrder : BLBase
    {
        #region Private Methods
        #region Insert
        private List<string> Insert(Order entity)
        {
            List<string> errorMessage = new List<string>();
            string queryInsert = "INSERT INTO `T_T_ORDER` (MENU_ID,MENU_NAME,MENU_TYPE,PRICE,IS_KAI_MOOK,IS_MOOK_POP,IS_FRUIT_SALAD,IS_JELLY_HONEY,IS_JELLY_STRAWBERRY,IS_JELLY_CARAMEL,DISCOUNT,ORDER_STATUS,CREATE_DATE,CREATE_USER,UPDATE_DATE,UPDATE_USER,NOTE1,IS_MEMBER,ID_MEMBER,TOTAL_PRICE) VALUES (";
            queryInsert += "'" + entity.MenuId + "',";
            queryInsert += "'" + entity.MenuName + "',";
            queryInsert += "'" + entity.MenuType + "',";
            queryInsert += "'" + entity.Price + "',";
            queryInsert += "" + entity.IsKaiMook + ",";
            queryInsert += "" + entity.IsMookPop + ",";
            queryInsert += "" + entity.IsFruitSalad + ",";
            queryInsert += "" + entity.IsJellyHoney + ",";
            queryInsert += "" + entity.IsJellyStrawberry + ",";
            queryInsert += "" + entity.IsJellyCaramel + ",";
            queryInsert += "'" + entity.Discount + "',";
            queryInsert += "'" + entity.OrderStatus + "',";
            queryInsert += "'" + Utility.ConvertDateTimeToText(entity.CreateDate) + "',";
            queryInsert += "'" + entity.CreateUser + "',";
            queryInsert += "'" + Utility.ConvertDateTimeToText(entity.UpdateDate) + "',";
            queryInsert += "'" + entity.UpdateUser + "',";
            queryInsert += "'" + entity.Note1 + "',";
            queryInsert += "" + entity.IsMember + ",";
            queryInsert += "'" + entity.IdMember + "',";
            queryInsert += "'" + entity.TotalPrice + "')";
            ExecuteNonQuery(queryInsert);
            return errorMessage;
        }
        #endregion Insert
        #region Update
        private List<string> Update(Order entity)
        {
            List<string> errorMessage = new List<string>();
            string queryUpdate = "UPDATE `T_T_ORDER` SET ";
            queryUpdate += "MENU_ID='" + entity.MenuId + "',";
            queryUpdate += "MENU_NAME='" + entity.MenuName + "',";
            queryUpdate += "MENU_TYPE='" + entity.MenuType + "',";
            queryUpdate += "PRICE='" + entity.Price + "',";
            queryUpdate += "IS_KAI_MOOK=" + entity.IsKaiMook + ",";
            queryUpdate += "IS_MOOK_POP=" + entity.IsMookPop + ",";
            queryUpdate += "IS_FRUIT_SALAD=" + entity.IsFruitSalad + ",";
            queryUpdate += "IS_JELLY_HONEY=" + entity.IsJellyHoney + ",";
            queryUpdate += "IS_JELLY_STRAWBERRY=" + entity.IsJellyStrawberry + ",";
            queryUpdate += "IS_JELLY_CARAMEL=" + entity.IsJellyCaramel + ",";
            queryUpdate += "DISCOUNT='" + entity.Discount + "',";
            queryUpdate += "ORDER_STATUS='" + entity.OrderStatus + "',";
            queryUpdate += "CREATE_DATE='" + Utility.ConvertDateTimeToText(entity.CreateDate) + "',";
            queryUpdate += "CREATE_USER='" + entity.CreateUser + "',";
            queryUpdate += "UPDATE_DATE='" + Utility.ConvertDateTimeToText(entity.UpdateDate) + "',";
            queryUpdate += "UPDATE_USER='" + entity.UpdateUser + "',";
            queryUpdate += "NOTE1='" + entity.Note1 + "',";
            queryUpdate += "IS_MEMBER=" + entity.IsMember + ",";
            queryUpdate += "ID_MEMBER='" + entity.IdMember + "',";
            queryUpdate += "TOTAL_PRICE='" + entity.TotalPrice + "'";
            queryUpdate += "WHERE " + entity.PK;
            ExecuteNonQuery(queryUpdate);
            return errorMessage;
        }
        #endregion Update
        #region Fill
        private List<Order> Fill(DataTable dt)
        {
            List<Order> entityCollection = new List<Order>();
            Order entity = null;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                entity = new Order();
                if (dt.Rows[i]["ID"] != DBNull.Value)
                {
                    entity.Id = (int)dt.Rows[i]["ID"];
                }
                else
                {
                    entity.Id = 0;
                }
                if (dt.Rows[i]["MENU_ID"] != DBNull.Value)
                {
                    entity.MenuId = (int)dt.Rows[i]["MENU_ID"];
                }
                else
                {
                    entity.MenuId = 0;
                }
                if (dt.Rows[i]["MENU_NAME"] != DBNull.Value)
                {
                    entity.MenuName = (string)dt.Rows[i]["MENU_NAME"];
                }
                else
                {
                    entity.MenuName = string.Empty;
                }
                if (dt.Rows[i]["MENU_TYPE"] != DBNull.Value)
                {
                    entity.MenuType = (string)dt.Rows[i]["MENU_TYPE"];
                }
                else
                {
                    entity.MenuType = string.Empty;
                }
                if (dt.Rows[i]["PRICE"] != DBNull.Value)
                {
                    entity.Price = Convert.ToInt32(dt.Rows[i]["PRICE"]);
                }
                else
                {
                    entity.Price = 0;
                }
                if (dt.Rows[i]["IS_KAI_MOOK"] != DBNull.Value)
                {
                    entity.IsKaiMook =Convert.ToBoolean(dt.Rows[i]["IS_KAI_MOOK"]);
                }
                else
                {
                    entity.IsKaiMook = false;
                }
                if (dt.Rows[i]["IS_MOOK_POP"] != DBNull.Value)
                {
                    entity.IsMookPop = Convert.ToBoolean(dt.Rows[i]["IS_MOOK_POP"]);
                }
                else
                {
                    entity.IsMookPop = false;
                }
                if (dt.Rows[i]["IS_FRUIT_SALAD"] != DBNull.Value)
                {
                    entity.IsFruitSalad = Convert.ToBoolean(dt.Rows[i]["IS_FRUIT_SALAD"]);
                }
                else
                {
                    entity.IsFruitSalad = false;
                }
                if (dt.Rows[i]["IS_JELLY_HONEY"] != DBNull.Value)
                {
                    entity.IsJellyHoney = Convert.ToBoolean(dt.Rows[i]["IS_JELLY_HONEY"]);
                }
                else
                {
                    entity.IsJellyHoney = false;
                }
                if (dt.Rows[i]["IS_JELLY_STRAWBERRY"] != DBNull.Value)
                {
                    entity.IsJellyStrawberry = Convert.ToBoolean(dt.Rows[i]["IS_JELLY_STRAWBERRY"]);
                }
                else
                {
                    entity.IsJellyStrawberry = false;
                }
                if (dt.Rows[i]["IS_JELLY_CARAMEL"] != DBNull.Value)
                {
                    entity.IsJellyCaramel = Convert.ToBoolean(dt.Rows[i]["IS_JELLY_CARAMEL"]);
                }
                else
                {
                    entity.IsJellyCaramel = false;
                }
                if (dt.Rows[i]["DISCOUNT"] != DBNull.Value)
                {
                    entity.Discount = Convert.ToInt32(dt.Rows[i]["DISCOUNT"]);
                }
                else
                {
                    entity.Discount = 0;
                }
                if (dt.Rows[i]["ORDER_STATUS"] != DBNull.Value)
                {
                    entity.OrderStatus = Convert.ToInt32(dt.Rows[i]["ORDER_STATUS"]);
                }
                else
                {
                    entity.OrderStatus = 0;
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
                if (dt.Rows[i]["NOTE1"] != DBNull.Value)
                {
                    entity.Note1 = (string)dt.Rows[i]["NOTE1"];
                }
                else
                {
                    entity.Note1 = string.Empty;
                }
                if (dt.Rows[i]["IS_MEMBER"] != DBNull.Value)
                {
                    entity.IsMember = Convert.ToBoolean(dt.Rows[i]["IS_MEMBER"]);
                }
                else
                {
                    entity.IsMember = false;
                }
                if (dt.Rows[i]["ID_MEMBER"] != DBNull.Value)
                {
                    entity.IdMember = (string)dt.Rows[i]["ID_MEMBER"];
                }
                else
                {
                    entity.IdMember = string.Empty;
                }
                if (dt.Rows[i]["TOTAL_PRICE"] != DBNull.Value)
                {
                    entity.TotalPrice = Convert.ToInt32(dt.Rows[i]["TOTAL_PRICE"]);
                }
                else
                {
                    entity.TotalPrice = 0;
                }
                entityCollection.Add(entity);
            }
            return entityCollection;
        }
        #endregion Fill
        #endregion
        #region Public Methods
        #region Find
        public List<Order> Find(string whereClause, string orderBy)
        {
            string queryText = "SELECT * FROM `T_T_ORDER` ";
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
        public List<string> Save(List<Order> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (Order entity in entityCollection)
            {
                Save(entity);
            }
            return errorMessage;
        }
        public List<string> Save(Order entity)
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
        public List<string> Delete(List<Order> entityCollection)
        {
            List<string> errorMessage = new List<string>();
            foreach (Order entity in entityCollection)
            {
                Delete(entity);
            }
            return errorMessage;
        }
        public List<string> Delete(Order entity)
        {
            List<string> errorMessage = new List<string>();
            string queryText = "DELETE FROM `T_T_ORDER` ";
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
                string queryText = "DELETE FROM `T_T_ORDER` ";
                queryText += "WHERE " + whereClause;
                ExecuteNonQuery(queryText);
            }
            return errorMessage;
        }
        #endregion DeleteWhere
        #region GetRecord
        public Order GetRecord(string whereClause)
        {
            List<Order> entityCollection = Find(whereClause, string.Empty);
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
            string queryText = "SELECT COUNT(*) FROM `T_T_ORDER` ";
            queryText += "WHERE " + whereClause;
            DataTable dt = GetDataTable(queryText);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            return result;
        }
        #endregion GetCount
        #region GetPage
        public List<Order> GetPage(string whereClause, string orderBy, int pageIndex, int pageSize)
        {
            string sql = string.Empty;
            int startIndex = pageSize * pageIndex;
            int endIndex = startIndex + pageSize;
            sql = " SELECT * ,ROW_NUMBER() OVER ( ORDER BY ID)AS INDEX_ROWS FROM `T_T_ORDER` WHERE ";
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
