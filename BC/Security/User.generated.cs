// Generate User FTPBubbleTea
// Generate Date 20/6/2022 21:30:16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FTPBubbleTea.BC.Security
{
    public partial class User : FTPBubbleTea.BC.EntityBase
    {
        #region Properties
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Int16 RoleId { get; set; }
        public DateTime LastLoginDate { get; set; }
        public Int16 UserStatus { get; set; }
        public Int16 UserRank { get; set; }
        public string Note1 { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public string PK
        {
            get { return "0=0  AND USER_ID ='" + this.UserId + "'"; }
        }
        #endregion
    }
}
