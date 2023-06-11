using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Doitac
{
    public string Madoitac { get; set; }

    public string Email { get; set; }

    public string Tenquan { get; set; }

    public string TpQuan { get; set; }

    public string Loaiamthuc { get; set; }

    public string DiachiKd { get; set; }

    public string Sdt { get; set; }

    public string Masothue { get; set; }

    public string MaNdd { get; set; }

    public virtual ICollection<Chinhanh> Chinhanhs { get; set; } = new List<Chinhanh>();

    public virtual Nguoidaidien MaNddNavigation { get; set; }
}
