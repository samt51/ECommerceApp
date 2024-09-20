using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Shared.Bases.Commond
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator mediator;
        public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
