using System.IdentityModel.Tokens.Jwt;

namespace LstSurveyApi
{
    public class TestMid
    {
        public RequestDelegate _next;

        public TestMid(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers.Authorization;
            if(!string.IsNullOrWhiteSpace(token))
            {
                var t = token.ToString().Split(' ')[1];
                
                    var tokenHandler = new JwtSecurityTokenHandler();
                if(tokenHandler.CanReadToken(t))
                {
                    var claimList = tokenHandler.ReadJwtToken(t).Claims;
                }
           
            }
            return _next.Invoke(context);
        }
    }
}
