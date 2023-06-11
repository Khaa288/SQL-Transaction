using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Monan
{
    public string Tenmon { get; set; }

    public string Mieuta { get; set; }

    public double? Gia { get; set; }

    public virtual ICollection<Bangdanhgium> Bangdanhgia { get; set; } = new List<Bangdanhgium>();

    public virtual ICollection<CtDonhang> CtDonhangs { get; set; } = new List<CtDonhang>();

    public virtual ICollection<Tuychonmon> Tuychonmons { get; set; } = new List<Tuychonmon>();

    public virtual ICollection<Chinhanh> Machinhanhs { get; set; } = new List<Chinhanh>();
}
