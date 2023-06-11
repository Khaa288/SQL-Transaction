using System;
using System.Collections.Generic;

namespace Project_DBMS.Models;

public partial class Khachhang
{
    public string Makh { get; set; }

    public string Hoten { get; set; }

    public string Sdt { get; set; }

    public string Diachi { get; set; }

    public string Email { get; set; }

    public virtual ICollection<Bangdanhgium> Bangdanhgia { get; set; } = new List<Bangdanhgium>();

    public virtual ICollection<Donhang> Donhangs { get; set; } = new List<Donhang>();
}
