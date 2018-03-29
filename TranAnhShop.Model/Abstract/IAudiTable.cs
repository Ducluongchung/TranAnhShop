using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhShop.Model.Models
{
    public interface IAudiTable
    {
        DateTime? CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }

        [MaxLength(256)]
        string MetaKeyword { get; set; }
        [MaxLength(256)]
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}
