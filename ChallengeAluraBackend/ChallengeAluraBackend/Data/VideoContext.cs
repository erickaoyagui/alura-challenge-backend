using ChallengeAluraBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAluraBackend.Data
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> opt) : base(opt)
        {
            
        }

        public DbSet<Video> Videos { get; set; }
    }
}
