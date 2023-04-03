// <auto-generated/>
#pragma warning disable
using Marten;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_data_id
    public class GET_data_id : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;
        private readonly Marten.ISessionFactory _sessionFactory;

        public GET_data_id(Wolverine.Http.WolverineHttpOptions options, Marten.ISessionFactory sessionFactory) : base(options)
        {
            _options = options;
            _sessionFactory = sessionFactory;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var serviceEndpoints = new WolverineWebApi.ServiceEndpoints();
            await using var documentSession = _sessionFactory.OpenSession();
            if (!Guid.TryParse((string)httpContext.GetRouteValue("id"), out var id))
            {
                httpContext.Response.StatusCode = 404;
                return;
            }


            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            var data = await serviceEndpoints.GetData(id, documentSession).ConfigureAwait(false);
            await WriteJsonAsync(httpContext, data);

            // Commit the unit of work
            await documentSession.SaveChangesAsync(httpContext.RequestAborted).ConfigureAwait(false);
        }

    }

    // END: GET_data_id
    
    
}

