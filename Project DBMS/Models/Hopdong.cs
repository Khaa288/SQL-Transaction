using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Hopdong
{
    public string Mahopdong { get; set; }

    public string MaNdd { get; set; }

    public string NvXuli { get; set; }

    public double? PtHoahong { get; set; }

    public double? Phikichhoat { get; set; }

    public DateTime? TgHieuluc { get; set; }

    public virtual Nguoidaidien MaNddNavigation { get; set; }

    public virtual Nhanvien NvXuliNavigation { get; set; }

    public virtual ICollection<Chinhanh> Machinhanhs { get; set; } = new List<Chinhanh>();
}
