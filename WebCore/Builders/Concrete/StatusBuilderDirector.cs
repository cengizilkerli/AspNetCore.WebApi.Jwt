using WebCore.Builders.Abstract;
using WebCore.Models;

namespace WebCore.Builders.Concrete
{
    public class StatusBuilderDirector
    {
        private StatusBuilder builder;
        public StatusBuilderDirector(StatusBuilder builder)
        {
            this.builder = builder;
        }

        public Status GenerateStatus(AppUser activeUser, string roles)
        {
            return builder.GenerateStatus(activeUser, roles);
        }
    }
}