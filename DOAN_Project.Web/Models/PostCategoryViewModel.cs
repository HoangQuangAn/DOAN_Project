using System;
using System.Collections.Generic;

namespace DOAN_Project.Web.Models
{
    public class PostCategoryViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<PostViewModel> Posts { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }

        public string UpdateBy { set; get; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}