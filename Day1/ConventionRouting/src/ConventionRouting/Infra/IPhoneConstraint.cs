using Microsoft.AspNet.Routing;
using System;
using Microsoft.AspNet.Http;
using System.Collections.Generic;

namespace ConventionRouting.Infra
{
    public class IPhoneConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, IDictionary<string, object> values, RouteDirection routeDirection)
        {
            return httpContext.Request.Headers["User-Agent"].Contains("iPhone");
        }
    }
}