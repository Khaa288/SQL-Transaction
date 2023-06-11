using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class CtDonhang
{
    public string Madonhang { get; set; }

    public string Machinhanh { get; set; }

    public string Tenmon { get; set; }

    public int? Soluong { get; set; }

    public virtual Chinhanh MachinhanhNavigation { get; set; }

    public virtual Donhang MadonhangNavigation { get; set; }

    public virtual Monan TenmonNavigation { get; set; }
}
