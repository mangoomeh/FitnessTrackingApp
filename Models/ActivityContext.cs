using Microsoft.EntityFrameworkCore;

namespace SportsTrackingApp.Models;

public class ActivityContext : DbContext
{
    public ActivityContext(DbContextOptions<ActivityContext> options)
        : base(options)
    {
    }

    public DbSet<FitnessActivity> FitnessActivities { get; set; } = null!;
}