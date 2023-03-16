using System;
using System.Collections.Generic;

namespace QuanLy_QuanAn.DataAccess;

public partial class FoodCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Food> Foods { get; } = new List<Food>();
}
