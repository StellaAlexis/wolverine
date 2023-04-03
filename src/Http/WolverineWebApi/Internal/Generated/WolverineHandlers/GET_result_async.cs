// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_result_async
    public class GET_result_async : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;

        public GET_result_async(Wolverine.Http.WolverineHttpOptions options) : base(options)
        {
            _options = options;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var result = await WolverineWebApi.ResultEndpoints.GetAsyncResult().ConfigureAwait(false);
            await result.ExecuteAsync(httpContext).ConfigureAwait(false);
        }

    }

    // END: GET_result_async
    
    
}

