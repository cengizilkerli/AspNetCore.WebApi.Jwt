using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwt(AppUser appUser, List<AppRole> roles);
    }
}
