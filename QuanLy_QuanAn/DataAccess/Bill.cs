using System;
using System.Collections.Generic;

namespace QuanLy_QuanAn.DataAccess;

public partial class Bill
{
    public int Id { get; set; }

    public DateTime DateCheckIn { get; set; }

    public DateTime? DateCheckout { get; set; }

    public int IdTable { get; set; }

    public int Status { get; set; }

    public virtual ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>();
}
