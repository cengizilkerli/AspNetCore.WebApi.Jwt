using Entities.Concrete;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAppRoleService : IGenericService<AppRole>
    {
        Task<AppRole> FindByName(string roleName);
    }
}
