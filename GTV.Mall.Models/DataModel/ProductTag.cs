namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class ProductTag
    {

        public Guid ProductTagID { get; set; }

        public Guid ProductID { get; set; }

        public Guid TagID { get; set; }

    }

}
