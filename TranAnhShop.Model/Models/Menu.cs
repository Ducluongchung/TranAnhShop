using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }

        public int DisplayOder { get; set; }
        [Required]
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
        public int GroupID { get; set; }
        [Required]
        public bool Static { get; set; }
    }
}
