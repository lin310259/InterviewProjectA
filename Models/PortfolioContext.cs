using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Enity;
using static WebApplication1.Models.Enum;

namespace WebApplication1.Models
{
    public class PortfolioContext : DbContext
    {
        public readonly DataStatus[] DISPLAY_STATUS = new DataStatus[] { DataStatus.Default, DataStatus.Normal };

        public PortfolioContext(DbContextOptions _options) : base(_options)
        {
        }

        public DbSet<UserData> Users { get; set; }
    }
}
