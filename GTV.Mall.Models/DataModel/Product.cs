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

    public partial class Product
    {

        public Guid ProductID { get; set; }

        public Guid SupplierID { get; set; }

        public string ProductNO { get; set; }

        public string ProductName { get; set; }

        public bool Preorder { get; set; }

        public string ShortPromo { get; set; }

        public string Description { get; set; }

        public int SalePrice { get; set; }

        public int Price { get; set; }

        public string Unit { get; set; }

        public int? Quantity { get; set; }

        public int? PurchaseQty { get; set; }

        public decimal? Weight { get; set; }

        public int? PrepareDay { get; set; }

        public DateTime? UploadStartDate { get; set; }

        public DateTime? UploadEndDate { get; set; }

        public DateTime? AvailableStartDate { get; set; }

        public DateTime? AvailableEndDate { get; set; }

        public string SoldoutMessage { get; set; }

        public string HashTags { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }

        public Guid UserID { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? ModifiedTime { get; set; }

    }
}
