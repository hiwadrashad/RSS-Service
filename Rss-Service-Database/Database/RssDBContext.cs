using Microsoft.EntityFrameworkCore;
using RSS_Service_Library.ModelsNu;
using RSS_Service_Library.ModelsTechRepublic;
using RSS_Service_Library.ModelsTechVisor;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSS_Service_Data_Base.Database
{
    public class RssDBContext : DbContext
    {
        public DbSet<NuRss> NuDatabase { get; set; }
        public DbSet<TechRepublicRss> TechRepublicDatabase { get; set; }
        public DbSet<TechVisorRss> TechVisorDatabase { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Database=Rss-Server; Trusted_Connection=True;");
            builder.UseSqlServer(@"Database=Rss-Server;Trusted_Connection=True");
        }

    }
}
