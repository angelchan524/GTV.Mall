namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class ProductMedia
    {

        public Guid MediaID { get; set; }

        public Guid ProductID { get; set; }

        public string MediaType { get; set; }

        public string Location { get; set; }

        public int? DisplayOrder { get; set; }

    }

}
