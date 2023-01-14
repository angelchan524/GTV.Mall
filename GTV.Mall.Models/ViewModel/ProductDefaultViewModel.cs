using GTV.Mall.Models.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Models.ViewModel
{

    public class ProductDefaultViewModel
    {
        public Guid ProductId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryType { get; set; }
        public string? Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int Price { get; set; } = 0;
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int Discount { get; set; } = 0;
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int SalePrice
        {
            get
            {
                return Price - Discount;
            }
        }
        public string? ImageUrl { get; set; }
        public ProductDefaultViewModel()
        {
            Discount = (int)(Price * 0.1);
        }
        public ProductDefaultViewModel(Product product)
        {
            ProductId = product.ProductID;
            CategoryName = product.ProductName;

            Discount = (int)(Price * 0.1);
        }
        //public DiscountSetting? DiscountSetting { get; set; }

        //private void CalcDiscount()
        //{
        //    if (DiscountSetting == null)
        //        Discount = 0;
        //    if (DiscountSetting.DiscountRate != null)
        //    {
        //        decimal offRate = 1 - (DiscountSetting.DiscountRate ?? 0);
        //        Discount = (int)Math.Floor(Price * offRate);
        //    }
        //}
    }
}
