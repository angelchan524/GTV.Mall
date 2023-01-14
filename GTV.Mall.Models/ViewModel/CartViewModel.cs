using GTV.Mall.Models.DataModel;
using GTV.Mall.Models.ViewModel.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Models.ViewModel
{
    public class CartViewModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        [ValidateNever]
        public Product Product { get; set; }
        [ValidateNever]
        public string ApplicationUserId { get; set; }
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        public int Count { get; set; }
    }
}
