using WebCore.Builders.Concrete;
using WebCore.Models;

namespace WebCore.Builders.Abstract
{
    public abstract class StatusBuilder
    {
        public abstract Status GenerateStatus(AppUser activeUser, string roles);
    }
}