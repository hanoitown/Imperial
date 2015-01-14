using Api.Infrastructure.Base;
using Imperial.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class CategoriesController : ApiBaseController
    {
        public CategoriesController(IUnitOfWork uow)
            : base(uow)
        {

        }
        // GET: api/Categories
        public IHttpActionResult Get()
        {
            return Ok(_uow.Products.All);
        }

        // GET: api/Categories/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
        }
    }
}
