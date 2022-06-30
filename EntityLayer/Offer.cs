using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class Offer : BaseEntity
    {
        [Key]
        public int OfferID { get; set; }
        public decimal Price { get; set; }
        public bool IsApproved { get; set; }
    //    public int ProductID { get; set; }
    //    public Product Product { get; set; }
    //    public int UserID { get; set; }
    //    public User User { get; set; }
    }
}
