using DVar.BLog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DVar.BLog.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<FeedbackResponse> FeedbackResponses { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
}