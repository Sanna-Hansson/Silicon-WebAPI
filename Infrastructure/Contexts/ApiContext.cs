using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Infrastructure.Contexts;

 public class ApiContext(DbContextOptions<ApiContext>options) : DbContext(options)
    {
        public DbSet<SubscriberEntity> Subscribers { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
    }

