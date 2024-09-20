using ECommerce.Shared.Bases.Dtos.OrderServiceDtos;
using ECommerce.Shared.Bases.Dtos.PaymentServiceDtos;
using ECommerce.Shared.Bases.Dtos.ResponseModel;
using MediatR;

namespace OrderService.Application.Features.Commands.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<ResponseDto<CreateOrderCommandResponse>>
    {
        public int BuyerId { get; set; }
        public IList<OrderItemDto> OrderItemDtos { get; set; }
        public PaymentDto PaymentDto { get; set; }
        public AddressDto AddressDto { get; set; }

    }
}
