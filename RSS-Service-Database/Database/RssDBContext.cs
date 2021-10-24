using Microsoft.EntityFrameworkCore;
using RSS_Service_Library.ModelsNu;
using RSS_Service_Library.ModelsTechRepublic;
using RSS_Service_Library.ModelsTechVisor;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSS_Service_Database.Database
{
    public class RssDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<NuRss> NuDatabase { get; set; }
        public DbSet<TechRepublicRss> TechRepublicDatabase { get; set; }
        public DbSet<TechVisorRss> TechVisorDatabase { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=itv-admin;Initial Catalog=msdb;Data Source=LAPTOP-1128");
        }

    }
}
