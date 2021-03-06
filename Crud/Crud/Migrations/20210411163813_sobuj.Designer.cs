// <auto-generated />
using Crud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Crud.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20210411163813_sobuj")]
    partial class sobuj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Crud.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductBrand")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ProductPrice")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ProductQuantity")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("ProductId");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
