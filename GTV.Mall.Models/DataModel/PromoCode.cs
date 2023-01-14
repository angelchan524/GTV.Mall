namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class PromoCode
    {

        public Guid PromoID { get; set; }

        public string PromoName { get; set; }

        public string PromoType { get; set; }

        public decimal? Ratio { get; set; }

        public int? Price { get; set; }

        public string Code { get; set; }

        public int CodeCount { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool Status { get; set; }

        public Guid UserID { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? ModifiedTime { get; set; }

    }

}
