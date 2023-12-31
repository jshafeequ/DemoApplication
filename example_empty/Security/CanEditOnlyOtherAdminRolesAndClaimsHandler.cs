﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace example_empty.Security
{
    public class CanEditOnlyOtherAdminRolesAndClaimsHandler :
     AuthorizationHandler<ManageAdminRolesAndClaimsRequirement>
    {

        private readonly IHttpContextAccessor httpContextAccessor;
     
        public CanEditOnlyOtherAdminRolesAndClaimsHandler(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            ManageAdminRolesAndClaimsRequirement requirement)
        {

            if (context.Resource is Endpoint endpoint)
            {
                if (endpoint.Metadata.OfType<IFilterMetadata>().Any(filter => filter is ManageAdminRolesAndClaimsRequirement))
                {
                   

                   
                    context.Succeed(requirement);
                    return Task.CompletedTask;
                }
            }
            // var tenant = _httpContextAccessor.HttpContext.GetRouteData().Values[ExceptionHandlerMiddleware.TenantCodeKey].ToString();

            var loggedInAdminId = context.User.Claims
            .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value.ToString();

            var adminIdBeingEdited = httpContextAccessor.HttpContext
                .Request.Query["userId"].ToString();

            if (context.User.IsInRole("admin")
                 && context.User.HasClaim(c => c.Type == "Edit Role" && c.Value == "true")
                 && adminIdBeingEdited.ToLower() != loggedInAdminId.ToLower())
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
