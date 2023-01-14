namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class ProductDiscount
    {

        public Guid ProductDiscountID { get; set; }

        public Guid ProductID { get; set; }

        public Guid? DiscountID { get; set; }

    }

}
