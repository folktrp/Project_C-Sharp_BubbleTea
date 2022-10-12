using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FTPBubbleTea.BC.Transaction
{
public partial class Order : FTPBubbleTea.BC.EntityBase
{
#region Properties
public int Id { get; set; }
public int MenuId { get; set; }
public string MenuName { get; set; }
public string MenuType { get; set; }
public int Price { get; set; }
public bool IsKaiMook { get; set; }
public bool IsMookPop { get; set; }
public bool IsFruitSalad { get; set; }
public bool IsJellyHoney { get; set; }
public bool IsJellyStrawberry { get; set; }
public bool IsJellyCaramel { get; set; }
public int Discount { get; set; }
public int OrderStatus { get; set; }
public DateTime CreateDate { get; set; }
public string CreateUser { get; set; }
public DateTime UpdateDate { get; set; }
public string UpdateUser { get; set; }
public string Note1 { get; set; }
public bool IsMember { get; set; }
public string IdMember { get; set; }
public int TotalPrice { get; set; }
public string PK
{
 get { return "0=0  AND ID ='"+this.Id+"'"; }
}
#endregion
}
}
