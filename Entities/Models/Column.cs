using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Column
    {
        public Column()
        {
            SystemLogs = new HashSet<SystemLog>();
            Values = new HashSet<Value>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<SystemLog> SystemLogs { get; set; }
        public virtual ICollection<Value> Values { get; set; }
    }
}
