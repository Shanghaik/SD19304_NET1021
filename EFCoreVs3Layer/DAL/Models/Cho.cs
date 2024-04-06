using System;
using System.Collections.Generic;

namespace EFCoreVs3Layer.DAL.Models
{
    public partial class Cho
    {
        public int MaCho { get; set; }
        public string? TenCho { get; set; }
        public int? MaDv { get; set; }

        public virtual Dongvat? MaDvNavigation { get; set; }
    }
}
