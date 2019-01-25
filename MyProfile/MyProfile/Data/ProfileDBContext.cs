using Microsoft.EntityFrameworkCore;
using MyProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Data
{
    public class ProfileDBContext : DbContext
    {
        public ProfileDBContext(DbContextOptions<ProfileDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
