using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranAnhShop.Model.Models;

namespace TranAnhShop.Model.Abstract
{
    public abstract class  AudiTable:IAudiTable
    {
       public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
       public  string CreatedBy { get; set; }

      public  DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

      public  string MetaKeyword { get; set; }

      public  string MetaDescription { get; set; }

       public bool Status { get; set; }
    }
}
