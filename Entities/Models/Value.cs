using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Entities.Models
{
    public partial class Value
    {
        [Key]
        public int Id { get; set; }
        [Column("RecordID")]
        public int? RecordId { get; set; }
        [Column("ColumnID")]
        public int? ColumnId { get; set; }
        [Column("Value")]
        [StringLength(50)]
        public string Value1 { get; set; }

        [ForeignKey(nameof(ColumnId))]
        [InverseProperty("Values")]
        public virtual Column Column { get; set; }
        [ForeignKey(nameof(RecordId))]
        [InverseProperty("Values")]
        public virtual Record Record { get; set; }
    }
}
