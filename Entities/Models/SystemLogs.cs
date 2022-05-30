using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Entities.Models
{
    public partial class SystemLogs
    {
        [Key]
        public int Id { get; set; }
        [Column("ColumnID")]
        public int ColumnId { get; set; }
        [Column("ValueID")]
        public int ValueId { get; set; }
        [Column("RecordID")]
        public int RecordId { get; set; }
        public  bool Added { get; set; }
        public bool Deleted { get; set; }
        public bool Updated { get; set; }
        [StringLength(50)]
        [Column("Description")]
        public string Description { get; set; }

        [ForeignKey(nameof(ColumnId))]
        [InverseProperty("SystemLogs")]
        public virtual Column Column { get; set; }

      

        [ForeignKey(nameof(RecordId))]
        [InverseProperty("SystemLogs")]
        public virtual Record Record { get; set; }








    }
}
