using ECommerce.Shared.Abstracts.DesignPatterns.UnitOfWorks;
using ECommerce.Shared.Abstracts.Mapper;
using ECommerce.Shared.Bases.Commond;
using ECommerce.Shared.Bases.Dtos.ResponseModel;
using MediatR;

namespace OrderService.Application.Features.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : BaseHandler, IRequestHandler<CreateOrderCommandRequest, ResponseDto<CreateOrderCommandResponse>>
    {
        public CreateOrderCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public Task<ResponseDto<CreateOrderCommandResponse>> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
