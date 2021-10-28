using System;
using System.Collections.Generic;

namespace DOAN_Project.Web.Models
{
    public class PostViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public int CategoryID { set; get; }

        public string Image { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public virtual PostCategoryViewModel PostCategory { set; get; }
        public IEnumerable<PostTagViewModel> PostTags { get; set; }
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }

        public string UpdateBy { set; get; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}