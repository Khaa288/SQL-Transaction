using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Nhanvien
{
    public string Manv { get; set; }

    public string Tennv { get; set; }

    public virtual ICollection<Hopdong> Hopdongs { get; set; } = new List<Hopdong>();
}
