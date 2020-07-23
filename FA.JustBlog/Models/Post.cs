using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The {0} must Category name is required.")]
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string Title { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string ShortDescription { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string PostContent { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string UrlSlug { get; set; }
        [DefaultValue(false)]
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        [DefaultValue(false)]
        public DateTime? ModifiedDate { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<PostTagMap> PostTagMaps { get; set; }
      //  public virtual IList<Tag> Tags { get; set; }
    }
}
