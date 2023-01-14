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

    public partial class DocumentType
    {

        public Guid DocumentTypeID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Notes { get; set; }

        public bool Status { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? ModifiedTime { get; set; }

    }

}
