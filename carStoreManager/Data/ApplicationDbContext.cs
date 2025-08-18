using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using carStoreManager.Models;
using carStoreManager.Models.Events;
using System.Security.Cryptography;

namespace carStoreManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<carStoreManager.Models.CartItem> CartItem { get; set; } = default!;

        private readonly Dictionary<Guid, SortedList<DateTime, Event>> _studentEvents = new();
        public void Append(Event @event)
        {
            var stream = _studentEvents.GetValueOrDefault(@event.EventId, null);
            if(stream is null)
            {
                _studentEvents[@event.EventId] = new SortedList<DateTime, Event>();
            }

            @event.CreatedAtUtc = DateTime.UtcNow;  
            _studentEvents[@event.EventId].Add(@event.CreatedAtUtc, @event);    
        }
    }
}
