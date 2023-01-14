namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class ProductAddon
    {

        public Guid ProductAddonID { get; set; }

        public Guid SupplierID { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int SalePrice { get; set; }

        public int Price { get; set; }

        public string Unit { get; set; }

        public int? Quantity { get; set; }

        public int? PurchaseQty { get; set; }

        public decimal? Weight { get; set; }

        public string Status { get; set; }

        public Guid UserID { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? ModifiedTime { get; set; }

    }

}
