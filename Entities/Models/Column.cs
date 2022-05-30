using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Entities.Models
{
    public partial class Column
    {
        public Column()
        {
            Values = new HashSet<Values>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Order { get; set; }
        public bool? IsVisible { get; set; }
      

        [InverseProperty(nameof(Models.Values.Column))]
        public virtual ICollection<Values> Values { get; set; }

        [InverseProperty(nameof(Models.SystemLogs.Column))]
        public virtual ICollection<SystemLogs> SystemLogs { get; set; }
    }
}
