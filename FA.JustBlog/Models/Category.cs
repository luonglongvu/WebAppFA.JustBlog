using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The {0} must Category name is required.")]
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string UrlSlug { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
