using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Bangdanhgium
{
    public string Mabang { get; set; }

    public string Makh { get; set; }

    public string Tenmon { get; set; }

    public bool? Likee { get; set; }

    public string Comment { get; set; }

    public int? Rate { get; set; }

    public virtual Khachhang MakhNavigation { get; set; }

    public virtual Monan TenmonNavigation { get; set; }
}
