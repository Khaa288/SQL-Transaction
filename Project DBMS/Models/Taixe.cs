using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Taixe
{
    public string Mataixe { get; set; }

    public string Hoten { get; set; }

    public string Cmnd { get; set; }

    public string Sdt { get; set; }

    public string Diachi { get; set; }

    public string Email { get; set; }

    public string Biensoxe { get; set; }

    public double? Phithuechan { get; set; }

    public string Khuvuchd { get; set; }

    public string Sotaikhoan { get; set; }

    public string Tennganhang { get; set; }

    public virtual ICollection<Donhang> Donhangs { get; set; } = new List<Donhang>();

    public virtual TaikhoanNh TaikhoanNh { get; set; }
}
