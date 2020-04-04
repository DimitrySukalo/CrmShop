using System;
using System.Collections.Generic;

namespace CrmModel.Model
{
    public class Check
    {
        public int CheckId { get; set; }
        
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime Created { get; set; }

        public ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return CheckId.ToString() + " " + DateTime.Now.ToString("dd.MM.yy hh:mm:ss");
        }

    }
}
