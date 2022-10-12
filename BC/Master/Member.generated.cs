// Generate User teerapat
// Generate Date 23/6/2022 20:17:26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FTPBubbleTea.BC.Master
{
public partial class Member : FTPBubbleTea.BC.EntityBase
{
#region Properties
public int Id { get; set; }
public string Tel { get; set; }
public string Name { get; set; }
public string Surname { get; set; }
public string NickName { get; set; }
public DateTime CreateDate { get; set; }
public string CreateUser { get; set; }
public DateTime UpdateDate { get; set; }
public string UpdateUser { get; set; }
public string PK
{
 get { return "0=0  AND ID ='"+this.Id+"'"; }
}
#endregion
}
}
