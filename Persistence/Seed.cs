using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
  public class Seed
  {
    public static async Task SeedData(DataContext context)
    {
      if (context.Events.Any()) return;

      var events = new List<Event>
            {
                new Event
                {
                    Title = "Past Event 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Event 2 months ago",
                    Category = "drinks",
                    City = "Austin",
                    Venue = "6th Street",
                },
                new Event
                {
                    Title = "Past Event 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Event 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Event
                {
                    Title = "Future Event 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Event 1 month in future",
                    Category = "culture",
                    City = "New York City",
                    Venue = "Natural History Museum",
                },
                new Event
                {
                    Title = "Future Event 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Event 2 months in future",
                    Category = "music",
                    City = "Dallas",
                    Venue = "Cowboys Stadium",
                },
                new Event
                {
                    Title = "Future Event 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Event 3 months in future",
                    Category = "drinks",
                    City = "Miami",
                    Venue = "Art Deco Historic District",
                },
                new Event
                {
                    Title = "Future Event 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Event 4 months in future",
                    Category = "outdoors",
                    City = "Los Angeles",
                    Venue = "Venice Beach",
                },
                new Event
                {
                    Title = "Future Event 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Event 5 months in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Buckingham Palace",
                },
                new Event
                {
                    Title = "Future Event 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Event 6 months in future",
                    Category = "travel",
                    City = "Seattle",
                    Venue = "Space Needle",
                },
                new Event
                {
                    Title = "Future Event 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Event 2 months ago",
                    Category = "travel",
                    City = "Washington DC",
                    Venue = "Lincoln Memorial",
                },
                new Event
                {
                    Title = "Future Event 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Event 8 months in future",
                    Category = "culture",
                    City = "Rome",
                    Venue = "The Colosseum",
                }
            };

      await context.Events.AddRangeAsync(events);
      await context.SaveChangesAsync();
    }
  }
}