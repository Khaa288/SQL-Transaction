using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Nguoidaidien
{
    public string MaNdd { get; set; }

    public string TenNdd { get; set; }

    public virtual ICollection<Doitac> Doitacs { get; set; } = new List<Doitac>();

    public virtual ICollection<Hopdong> Hopdongs { get; set; } = new List<Hopdong>();
}
