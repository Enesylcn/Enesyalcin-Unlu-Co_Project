using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Usage : BaseEntity
    {
        [Key]
        public int UsageID { get; set; }
        public string Name { get; set; }
        //public ICollection<Product> Products { get; set; }
    }
}
