using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace WebCore.CustomFilters
{
    public class JwtAuthorize : ActionFilterAttribute
    {
        public string Roles { get; set; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string token;

            if (JwtAuthorizeHelper.CheckToken(context, out token))
            {
                var responseMessage = JwtAuthorizeHelper.GetActiveUserResponseMessage(token);
                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    JwtAuthorizeHelper.CheckUserRole(JwtAuthorizeHelper.GetActiveUser(responseMessage), Roles, context);

                }
                else if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
                {
                    context.HttpContext.Session.Remove("token");
                    context.Result = new RedirectToActionResult("SignIn", "Account", null);
                }
                else
                {
                    var statusCode = responseMessage.StatusCode.ToString();
                    context.HttpContext.Session.Remove("token");
                    context.Result = new RedirectToActionResult("ApiError", "Account", new { code = statusCode });

                }
            }
        }
    }
}