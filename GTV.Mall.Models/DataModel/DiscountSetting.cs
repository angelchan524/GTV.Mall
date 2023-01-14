using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Models.DataModel
{

    using System;
    using System.Collections.Generic;

    public partial class DiscountSetting
    {

        public Guid DiscountID { get; set; }

        public string DiscountName { get; set; }

        public string ShortPromo { get; set; }

        public bool UsePriceDiscount { get; set; }

        public decimal? DiscountRate { get; set; }

        public bool UsePurchaseOver { get; set; }

        public int? PurchasePrice { get; set; }

        public int? DiscountPrice { get; set; }

        public bool UseFreeDelivery { get; set; }

        public bool? FreeDelivery { get; set; }

        public Guid UserID { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? ModifiedTime { get; set; }

    }

}
