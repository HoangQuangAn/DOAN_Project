using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOAN_Project.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(50)]
        public string TagID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int PostID { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}