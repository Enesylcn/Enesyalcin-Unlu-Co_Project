using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Common
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
