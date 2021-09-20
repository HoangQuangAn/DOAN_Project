using DOAN_Project.Model.Models;
using DOAN_Project.Service;
using DOAN_Project.Web.Infrastructures.Core;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DOAN_Project.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this.postCategoryService = postCategoryService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listCategory=postCategoryService.GetAll();
                    postCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return response;
            });
        }
        public HttpResponseMessage Post(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, ()=>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category=postCategoryService.Add(postCategory);
                    postCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.Created, category);
                }
                return response;
            });
        }

        public HttpResponseMessage Put(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    postCategoryService.Update(postCategory);
                    postCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    postCategoryService.Delete(id);
                    postCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}