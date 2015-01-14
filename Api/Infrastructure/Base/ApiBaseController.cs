using Imperial.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Api.Infrastructure.Base
{
    public class ApiBaseController : ApiController
    {
        //protected ModelFactory _modelFactory;
        protected IUnitOfWork _uow;

        public ApiBaseController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public ApiBaseController()
        {
        }


        protected HttpResponseMessage GetResponse(HttpRequestMessage request, Func<HttpResponseMessage> codeToExecute)
        {
            HttpResponseMessage response = null;

            try
            {
                response = codeToExecute.Invoke();
            }
            //catch (SecurityException ex)
            //{
            //    response = request.CreateResponse(HttpStatusCode.Unauthorized, ex.Message);
            //}
            //catch (FaultException<AuthorizationValidationException> ex)
            //{
            //    response = request.CreateResponse(HttpStatusCode.Unauthorized, ex.Message);
            //}
            //catch (FaultException ex)
            //{
            //    response = request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            //}
            catch (Exception ex)
            {
                response = request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }

    }
}