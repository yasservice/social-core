using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_core_exended.Models
{
    public class UserDataContext : DbContext
    {

        public UserDataContext(DbContextOptions<UserDataContext> options)
            :base(options)
        {

        }

        public DbSet<UserDataModel> users { get; set; }
    }
}
