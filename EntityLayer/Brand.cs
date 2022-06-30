using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Brand:BaseEntity
    {
        [Key]
        public int BrandID { get; set; }
        public string Name { get; set; }
        //public ICollection<Product> Products { get; set; }
    }
}
