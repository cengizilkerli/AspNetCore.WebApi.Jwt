using System.Threading.Tasks;
using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AppRoleManager : GenericManager<AppRole>,IAppRoleService
    {
        private readonly IGenericDal<AppRole> _genericDal;
        public AppRoleManager(IGenericDal<AppRole> genericDal): base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<AppRole> FindByName(string roleName)
        {
            return await _genericDal.GetByFilter(I => I.Name == roleName);
        }
    }
}
