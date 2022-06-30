using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Product : BaseEntity
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold { get; set; }
        //public ICollection<Offer> Offers { get; set; }
        //public int UserID { get; set; }
        //public User User { get; set; }
        //public int CategoryID { get; set; }
        //public Category Category { get; set; }
        //public int? BrandID { get; set; }
        //public Brand Brand { get; set; }
        //public int UsageID { get; set; }
        //public Usage Usage { get; set; }
        //public int? ColorID { get; set; }
        //public Color Color { get; set; }

        //[NotMapped]
        //[Display(Name = "Image")]
        ////[Required(ErrorMessage = "Please choose image to upload.")]
        //public IFormFile Image { get; set; }
    }
}
