using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WMS.Models;

namespace WMS.Data
{
    public class WMSContext : DbContext
    {
        public WMSContext (DbContextOptions<WMSContext> options)
            : base(options)
        {
        }

        public DbSet<WMS.Models.Login>? Login { get; set; }
    }
}
