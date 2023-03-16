using System;
using System.Collections.Generic;

namespace QuanLy_QuanAn.DataAccess;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
