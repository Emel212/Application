using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Record
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
