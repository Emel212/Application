using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class SystemLog
    {
        public int Id { get; set; }
        public int? ColumnId { get; set; }
        public int? ValueId { get; set; }
        public string RecordId { get; set; }
        public bool? Added { get; set; }
        public bool? Deleted { get; set; }
        public bool? Updated { get; set; }
        public string Description { get; set; }

        public virtual Column Column { get; set; }
        public virtual Value Value { get; set; }
       
    }
}
