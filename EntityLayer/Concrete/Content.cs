using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; } //içeriği
        public DateTime ContentDate { get; set; }

        //Content-Heading İlişkisi
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        //Content Yazar İlişkisi
        public int? WriterId { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
