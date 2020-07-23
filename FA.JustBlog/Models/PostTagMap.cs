using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models
{
    public class PostTagMap
    {
        [Key]
        [Column(Order = 1)]
        public int PostId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TagId { get; set; }
    }
}
