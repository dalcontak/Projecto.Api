using Microsoft.AspNet.Identity.EntityFramework;

namespace Simple.Api
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
            
        }
    }
}