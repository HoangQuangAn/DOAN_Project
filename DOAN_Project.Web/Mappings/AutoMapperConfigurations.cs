using AutoMapper;
using DOAN_Project.Model.Models;
using DOAN_Project.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_Project.Web.Mappings
{
    public class AutoMapperConfigurations
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}