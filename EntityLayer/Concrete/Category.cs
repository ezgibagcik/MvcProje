using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName  { get; set; }
        [StringLength(200)]
        public string CategoyDescription  { get; set; }
        public bool CategoryStatus  { get; set; } //durumu pasif-aktif hale getirmek
        public ICollection<Heading> Headings { get; set; }
    }
}
