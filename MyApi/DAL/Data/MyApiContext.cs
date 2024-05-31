using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DAL.Data
{
    public class MyApiContext : DbContext
    {
        public MyApiContext(DbContextOptions options) : base(options)
        {
        }
        public System.Data.Entity.DbSet<Image> Images { get; init; }
        public System.Data.Entity.DbSet<Effect> Effects { get; init; }
    }
}
