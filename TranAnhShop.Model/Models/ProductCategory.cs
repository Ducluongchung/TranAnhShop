﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranAnhShop.Model.Abstract;

namespace TranAnhShop.Model.Models
{
    public class ProductCategory : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }

        public int ParentID { get; set; }

        public string Description { get; set; }

        public int DisplayOder{ get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

    }
}
