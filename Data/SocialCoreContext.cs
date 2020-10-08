using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialCore.Models
{
    public class SocialCoreContext : DbContext
    {
        public SocialCoreContext (DbContextOptions<SocialCoreContext> options)
            : base(options)
        {
        }

        public DbSet<SocialCore.Models.UserProfile> UserProfile { get; set; }
    }
}
