using Data;
using ServiceLayer.EfServices;

namespace ServiceLayer
{
    public class Services
    {
        private readonly IUnitOfWork _unitOfWork;

        private EfPostService _post;
        private EfCommentService _comment;

        public Services(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual EfPostService Post
        {
            get { return _post ?? new EfPostService(_unitOfWork ); }
            set { _post = value; }
        }

        public EfCommentService Comment
        {
            get { return _comment ?? new EfCommentService(_unitOfWork); }
            set { _comment = value; }
        }
    }
}