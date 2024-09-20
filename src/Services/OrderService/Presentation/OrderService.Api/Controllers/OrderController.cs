using ECommerce.Shared.Bases.Commond;
using ECommerce.Shared.Bases.Dtos.ResponseModel;
using MediatR;
using OrderService.Application.Features.Commands.CreateOrder;

namespace OrderService.Api.Controllers
{
    public class OrderController : BaseController
    {
        public OrderController(IMediator mediator) : base(mediator)
        {
        }

        public async Task<ResponseDto<CreateOrderCommandResponse>> CreateOrderAsync(CreateOrderCommandRequest request)
        {
            return await mediator.Send(request);
        }
    }
}
