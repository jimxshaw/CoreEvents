using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Events
{
  public class Create
  {
    public class Command : IRequest
    {
      public Event Event { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
      private readonly DataContext _context;

      public Handler(DataContext context)
      {
        _context = context;
      }

      public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
      {
        _context.Events.Add(request.Event);

        await _context.SaveChangesAsync();

        // This in reality only lets us know the above
        // command is finished.
        return Unit.Value;
      }
    }
  }
}