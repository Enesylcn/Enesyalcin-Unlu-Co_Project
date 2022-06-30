using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public string VerifyCode { get; set; }
        public DateTime VerifyDate { get; set; }
        public bool Verified { get; set; }
        public DateTime LastLoginDate { get; set; }
    //    public ICollection<Offer> Offers { get; set; }
    }
}
