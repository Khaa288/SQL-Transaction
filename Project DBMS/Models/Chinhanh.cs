using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Chinhanh
{
    public string Machinhanh { get; set; }

    public string DcChinhanh { get; set; }

    public TimeSpan? Giomocua { get; set; }

    public TimeSpan? Giodongcua { get; set; }

    public string TtChinhanh { get; set; }

    public string Sotaikhoan { get; set; }

    public string Tennganhang { get; set; }

    public string Madoitac { get; set; }

    public virtual ICollection<CtDonhang> CtDonhangs { get; set; } = new List<CtDonhang>();

    public virtual ICollection<Donhang> Donhangs { get; set; } = new List<Donhang>();

    public virtual Doitac MadoitacNavigation { get; set; }

    public virtual TaikhoanNh TaikhoanNh { get; set; }

    public virtual ICollection<Hopdong> Mahopdongs { get; set; } = new List<Hopdong>();

    public virtual ICollection<Monan> Tenmonans { get; set; } = new List<Monan>();
}
