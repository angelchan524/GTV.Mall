namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class ProductDelivery
    {

        public Guid ProductDeliveryID { get; set; }

        public Guid ProductID { get; set; }

        public string DeliveryType { get; set; }

    }

}
