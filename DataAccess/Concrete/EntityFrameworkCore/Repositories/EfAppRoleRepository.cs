using DataAccess.Interfaces;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppRoleRepository : EfGenericRepository<AppRole>, IAppRoleDal
    {
    }
}
