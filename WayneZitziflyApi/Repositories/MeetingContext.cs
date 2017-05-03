using Microsoft.EntityFrameworkCore;
using WayneZitziflyApi.Model;

namespace WayneZitziflyApi.Repositories
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<User> Users { get; set; }
    }
}