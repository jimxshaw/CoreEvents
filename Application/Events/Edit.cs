using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Events
{
  public class Edit
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
        var eventToEdit = await _context.Events.FindAsync(request.Event.Id);

        eventToEdit.Title = request.Event.Title ?? eventToEdit.Title;

        await _context.SaveChangesAsync();

        return Unit.Value;
      }
    }
  }
}