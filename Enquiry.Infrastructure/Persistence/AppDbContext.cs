using Enquiry.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enquiry.Infrastructure.Persistence
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<EnquiryStatus> EntityStatuses { get; set; }
        public DbSet<EnquiryType> EntityTypes { get; set; }
        public DbSet<EnquiryModel> EntityModels { get; set; }

    }
}