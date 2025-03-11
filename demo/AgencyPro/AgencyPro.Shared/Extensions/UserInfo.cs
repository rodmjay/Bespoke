using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AgencyPro.Shared.Extensions
{
    public class UserInfo
    {
        public List<string> Roles { get; }

        public static UserInfo Load(ClaimsPrincipal claimsPrincipal)
        {
            var roles = claimsPrincipal.Claims.Where(x => x.Type == "role").Select(x => x.Value).ToList();
            return new UserInfo(roles);
        }
        
        private UserInfo(List<string> roles)
        {
            Roles = roles;
        }
    }
}
