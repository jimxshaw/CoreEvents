using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BaseApiController : ControllerBase
  {
    private IMediator _mediator;

    // If _mediator is null then assign to the property
    // the Mediator service. 
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
  }
}