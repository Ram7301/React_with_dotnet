using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class Stock
    {
        public int Id {set; get; }
        public string Symbol {set; get; } = string.Empty;
        public string CompanyName {set; get; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set;}
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; } 
        public List<Comment> Comments { get; set; } = new List<Comment>(); 

        
    }
}