using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FTPBubbleTea.BC.Master
{
    public partial class Menu : FTPBubbleTea.BC.EntityBase
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int PriceHot { get; set; }
        public int PriceCool { get; set; }
        public int PriceSpin { get; set; }
        public string Note1 { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public string PK
        {
            get { return "0=0  AND ID ='" + this.Id + "'"; }
        }
        #endregion
    }
}
