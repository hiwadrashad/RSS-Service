// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RSS_Service_Data_Base.Database;

namespace Rss_Service_Database.Migrations
{
    [DbContext(typeof(RssDBContext))]
    [Migration("20211026142932_initialdatabase")]
    partial class initialdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RSS_Service_Library.ModelsNu.NuRss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Atom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Version")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NuDatabase");
                });

            modelBuilder.Entity("RSS_Service_Library.ModelsTechRepublic.TechRepublicRss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Atom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Itunes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("S")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Version")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TechRepublicDatabase");
                });

            modelBuilder.Entity("RSS_Service_Library.ModelsTechVisor.TechVisorRss", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Version")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TechVisorDatabase");
                });
#pragma warning restore 612, 618
        }
    }
}
