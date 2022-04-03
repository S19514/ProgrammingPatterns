using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern
{
    public class AuthorizationHandler : BaseHandler
    {
        private Dictionary<int, int> _entityOwners = new Dictionary<int, int>()
        {
            {100, 13},
            {101, 14}
        };
        
        public AuthorizationHandler(IHandler next): base(next)
        {
            
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("AuthorizationHandler");
            if (requestContext.Request.UserRole == "Admin")
            {
                _next.Handle(requestContext);
                return;
            }

            if (_entityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId))
            {
                if (ownerId == requestContext.Request.UserId)
                {
                    _next.Handle(requestContext);
                    return;
                }
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "User is not authorized";
        }
    }
}