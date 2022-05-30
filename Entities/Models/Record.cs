using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Entities.Models
{
    public partial class Record
    {
        public Record()
        {
            Values = new HashSet<Values>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyTime { get; set; }

        [InverseProperty(nameof(Models.Values.Record))]
        public virtual ICollection<Values> Values { get; set; }

         [InverseProperty(nameof(Models.SystemLogs.Record))]
        public virtual ICollection<SystemLogs> SystemLogs { get; set; }




      
    }
}
