using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.Models
{
    public class OwnedProducts
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string OwnedProductCode { get; set; }
        public string OwnedProductName { get; set; }
    }
}