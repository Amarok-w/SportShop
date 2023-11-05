using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace SportShop
{
    partial class SaleComposition
    {
        public decimal TotalCost
        {
            get
            {
                try
                {
                    return Convert.ToDecimal(Product.Price) * Convert.ToDecimal(Amount);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {

            }
        }
    }

    //partial class Sale
    //{
    //    public decimal TotalSum
    //    {
    //        get
    //        {
    //            try
    //            {
    //                return SaleComposition.Sum(x => x.TotalCost);
    //            }
    //            catch
    //            {
    //                return 0;
    //            }
    //        }
    //        set
    //        {

    //        }
    //    }
    //}
}
