using Api.Models;
using Imperial.Data.Entities;
using Imperial.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class ValuesController : ApiController
    {
        ITaxService _taxService;
        IUnitOfWork _uow;
        public ValuesController(ITaxService taxService, IUnitOfWork uow)
        {
            _taxService = taxService;
            _uow = uow;
        }

        // GET api/values
        public PagedResult<Product> Get(int pageNo = 1, int pageSize = 50, [FromUri] string[] sort = null, string search = null)
        {
            var data = _uow.Products.All;

            // Determine the number of records to skip
            int skip = (pageNo - 1) * pageSize;

            if (!string.IsNullOrEmpty(search))
            {
                string[] filterElements = search.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string element in filterElements)
                {
                    data = data.Where(p => p.Name.Contains(element) || p.Description.Contains(element));
                }
            }

            if (sort != null)
            {
                data = data.ApplySorting(sort);
            }
            else
            {
                data = data.OrderBy(p => p.Id);
            }

            // Get the total number of records
            int totalItemCount = data.Count();

            // Retrieve the customers for the specified page
            var products = data
                .Skip(skip)
                .Take(pageSize)
                .ToList();           
            

            // Return the paged results
            return new PagedResult<Product>(products, pageNo, pageSize, totalItemCount);
        }

        // GET api/values/5
        public Product Get(string id)
        {
            return _uow.Products.All.Where(p => p.Name.Contains(id)).FirstOrDefault();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
