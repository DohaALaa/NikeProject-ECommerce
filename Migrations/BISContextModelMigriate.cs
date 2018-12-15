using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Nike_Project_Core.Migrations
{
    [DbContext(typeof(Context))]
    partial class BISContextModelMigriate : ModelSnapshot
    {                              
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("BookStore_Core_Project.Models.Books", b =>
            {
                b.Property<int>("BookID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CategoryBook");

                b.Property<string>("BookName")
                    .IsRequired()
                    .HasMaxLength(50);

                b.Property<string>("BookDescription")
                                .IsRequired();

                b.Property<decimal>("Price")
                                .HasColumnType("decimal(18,2)");

                b.HasKey("BookID");    

                b.ToTable("Books");
            });
        }
    }
}

