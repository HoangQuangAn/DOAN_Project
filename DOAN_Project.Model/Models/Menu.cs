using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOAN_Project.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        public int GroupID { get; set; }
        //Foreign Key
        [ForeignKey("GroupID")] // groupid is FK and it ref to MenuGroup
        public virtual MenuGroup MenuGroup { get; set; }

        public string Target { get; set; }
        [Required]  
        public bool Status { get; set; }
    }
}