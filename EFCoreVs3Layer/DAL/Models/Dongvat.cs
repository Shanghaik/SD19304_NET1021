using System;
using System.Collections.Generic;

namespace EFCoreVs3Layer.DAL.Models
{
    public partial class Dongvat
    {
        public int MaDv { get; set; }
        public string? TenDv { get; set; }
        public virtual ICollection<Cho> Chos { get; set; }
    }
}
