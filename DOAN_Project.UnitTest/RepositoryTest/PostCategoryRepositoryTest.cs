using DOAN_Project.Data.Infrastructure;
using DOAN_Project.Data.Repositories;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DOAN_Project.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IUnitOfWork unitOfWork;
        private IPostCategoryRepository postCategoryRepository;

        [TestInitialize]
        public void Initiali()
        {
            dbFactory = new DbFactory();
            postCategoryRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            //PostCategory postCategory = new PostCategory();
            //postCategory.Name = "Test Category";
            //postCategory.Alias = "Alias Category";
            //postCategory.Status = true;

            var result = postCategoryRepository.Delete(2);
            unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = postCategoryRepository.GetAll().ToList();
            Assert.AreEqual(0, list.Count);
        }

    }
}