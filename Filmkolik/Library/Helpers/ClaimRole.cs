using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static Filmkolik.Entities.Entity.Enums;

namespace Filmkolik.Library.Helpers
{
    public class ClaimRole
    {
        public class ClaimRequirementAttribute : TypeFilterAttribute
        {
            public ClaimRequirementAttribute(string claimType, params string[] claims) : base(typeof(ClaimRequirementFilter))
            {
                Arguments = new object[] { new Claim(claimType, string.Join(",", claims)) };
            }
        }

        public class ClaimRequirementFilter : IAuthorizationFilter
        {
            readonly Claim _claim;

            public ClaimRequirementFilter(Claim claim)
            {
                _claim = claim;
            }

            public void OnAuthorization(AuthorizationFilterContext context)
            {
                var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && _claim.Value.Split(",").Contains(c.Value));
                if (!hasClaim)
                {
                    context.Result = new ForbidResult();
                }
            }
        }
    }
}
