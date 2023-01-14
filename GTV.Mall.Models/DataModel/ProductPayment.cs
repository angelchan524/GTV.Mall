namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class ProductPayment
    {

        public Guid ProductPaymentID { get; set; }

        public Guid ProductID { get; set; }

        public string PaymentType { get; set; }

    }

}
