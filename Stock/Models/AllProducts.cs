using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Stock.Models
{
    public class AllProducts
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public double InitPrice { get; set; }
        public int FreeAmount { get; set; }
        public int OwnedAmount { get; set; }
    }

}