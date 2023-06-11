using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class TaikhoanNh
{
    public string Sotaikhoan { get; set; }

    public string Tennganhang { get; set; }

    public string ChinhanhNh { get; set; }

    public virtual ICollection<Chinhanh> Chinhanhs { get; set; } = new List<Chinhanh>();

    public virtual ICollection<Taixe> Taixes { get; set; } = new List<Taixe>();
}
