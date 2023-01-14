using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Models.ViewModel
{
    public class RecommendViewModel : MenuItem
    {
        public List<ProductDefaultViewModel> RecommendItems { get; set; }
    }
}
