using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Value
    {
        public Value()
        {
            SystemLogs = new HashSet<SystemLog>();
        }
        public int Id { get; set; }
        public string RecordId { get; set; }
        public int ColumnId { get; set; }
        public string Value1 { get; set; }

        public virtual Column Column { get; set; }
     
        public virtual ICollection<SystemLog> SystemLogs { get; set; }
    }
}
