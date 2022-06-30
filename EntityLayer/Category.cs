using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Category:BaseEntity
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       // public ICollection<Product> Products { get; set; }
    }
}
