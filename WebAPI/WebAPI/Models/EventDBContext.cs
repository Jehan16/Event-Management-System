using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class EventDBContext:DbContext
    {
        public EventDBContext(DbContextOptions<EventDBContext> options):base(options)
        {
            
        }

        public DbSet<EAttendee> EAttendees { get; set; }
    }
}
