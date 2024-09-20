using ECommerce.Shared.Abstracts.DesignPatterns.UnitOfWorks;
using ECommerce.Shared.Abstracts.Mapper;

namespace ECommerce.Shared.Bases.Commond
{
    public class BaseHandler
    {
        public readonly IMapper mapper;
        public readonly IUnitOfWork unitOfWork;
        public BaseHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
    }
}
