using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TableView
    {  
       
        public Column _column { get; set; }
       
        public  Value _values { get; set; }
    }
}
