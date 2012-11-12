using Data;
using DomainModel;
using ServiceLayer.ServiceDbSet;

namespace ServiceLayer.EfServices
{
    public  class EfPostService : ServiceContext<Post>
    {
        public   EfPostService(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}