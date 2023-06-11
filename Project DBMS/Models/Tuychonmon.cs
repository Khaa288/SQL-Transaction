using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Tuychonmon
{
    public string Tenmon { get; set; }

    public string Tuychon { get; set; }

    public virtual Monan TenmonNavigation { get; set; }
}
