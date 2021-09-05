using DOAN_Project.Data.Repositories;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;
using DOAN_Project.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace DOAN_Project.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<PostCategory> lstCategory;
        [TestInitialize]
        public void Initalize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _postCategoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            lstCategory = new List<PostCategory>()
            {
                new PostCategory(){ID=1, Name="DM1", Status=true},
                new PostCategory(){ID=2, Name="DM2", Status=true},
                new PostCategory(){ID=3, Name="DM2", Status=true}
            };

        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            _mockRepository.Setup(m => m.GetAll(null)).Returns(lstCategory);
            var result = _postCategoryService.GetAll() as List<PostCategory>;
            Assert.AreEqual(3, result.Count);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory postCategory = new PostCategory()
            {
                ID = 1,
                Name = "An",
                Alias = "Test",
                Status = true
            };
            _mockRepository.Setup(m => m.Add(postCategory)).Returns((PostCategory a) =>
              {
                  a.ID = 1;
                  return a;
              });
            var result=_postCategoryService.Add(postCategory);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}