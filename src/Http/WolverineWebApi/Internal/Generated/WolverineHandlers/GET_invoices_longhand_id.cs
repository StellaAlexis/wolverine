// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Marten.Publishing;
using Wolverine.Runtime;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_invoices_longhand_id
    public class GET_invoices_longhand_id : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly Wolverine.Runtime.IWolverineRuntime _wolverineRuntime;
        private readonly Wolverine.Marten.Publishing.OutboxedSessionFactory _outboxedSessionFactory;

        public GET_invoices_longhand_id(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, Wolverine.Runtime.IWolverineRuntime wolverineRuntime, Wolverine.Marten.Publishing.OutboxedSessionFactory outboxedSessionFactory) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _wolverineRuntime = wolverineRuntime;
            _outboxedSessionFactory = outboxedSessionFactory;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var messageContext = new Wolverine.Runtime.MessageContext(_wolverineRuntime);
            // Building the Marten session
            await using var querySession = _outboxedSessionFactory.QuerySession(messageContext);
            System.Guid id = default;
            System.Guid.TryParse(httpContext.Request.Query["id"], System.Globalization.CultureInfo.InvariantCulture, out id);
            
            // The actual HTTP request handler execution
            var result = await WolverineWebApi.Marten.InvoicesEndpoint.GetInvoice(id, querySession, httpContext.RequestAborted).ConfigureAwait(false);

            await result.ExecuteAsync(httpContext).ConfigureAwait(false);
        }

    }

    // END: GET_invoices_longhand_id
    
    
}

