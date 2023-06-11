using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Donhang
{
    public string Madonhang { get; set; }

    public string Chinhanh { get; set; }

    public string Khachhang { get; set; }

    public string Taixexuli { get; set; }

    public DateTime? Ngaylap { get; set; }

    public string Hinhthucthanhtoan { get; set; }

    public string Tinhtrang { get; set; }

    public double? Phivanchuyen { get; set; }

    public double? Tongtien { get; set; }

    public virtual Chinhanh ChinhanhNavigation { get; set; }

    public virtual ICollection<CtDonhang> CtDonhangs { get; set; } = new List<CtDonhang>();

    public virtual Khachhang KhachhangNavigation { get; set; }

    public virtual Taixe TaixexuliNavigation { get; set; }
}
