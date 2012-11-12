using Data;
using DomainModel;
using ServiceLayer.ServiceDbSet;

namespace ServiceLayer.EfServices
{
    public class EfCommentService : ServiceContext<Comment>
    {
        public EfCommentService(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}