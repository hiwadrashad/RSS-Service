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
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RSSFeed;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void AddNuRss(NuRss input)
        {
            NuDatabase.Add(input);
            
        }

    }
}
