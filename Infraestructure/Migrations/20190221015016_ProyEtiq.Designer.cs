﻿// <auto-generated />
using System;
using Infraestructure.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestructure.Migrations
{
    [DbContext(typeof(ItrebolsoftDbContext))]
    [Migration("20190221015016_ProyEtiq")]
    partial class ProyEtiq
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.TBlog", b =>
                {
                    b.Property<Guid>("PublId")
                        .HasColumnName("publ_id");

                    b.Property<Guid?>("FkTUserUserId")
                        .HasColumnName("fk_t_user_user_id");

                    b.Property<string>("PublBody")
                        .HasColumnName("publ_body")
                        .HasMaxLength(5000)
                        .IsUnicode(false);

                    b.Property<int?>("PublCalif")
                        .HasColumnName("publ_calif")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<DateTime?>("PublDate")
                        .HasColumnName("publ_date")
                        .HasColumnType("date");

                    b.Property<string>("PublDesc")
                        .HasColumnName("publ_desc")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("PublEtiq")
                        .HasColumnName("publ_etiq")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("PublName")
                        .HasColumnName("publ_name")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("PublId");

                    b.HasIndex("FkTUserUserId");

                    b.ToTable("t_blog");
                });

            modelBuilder.Entity("Domain.TImages", b =>
                {
                    b.Property<Guid>("ImageId")
                        .HasColumnName("image_id");

                    b.Property<Guid?>("FkTBlogPublId")
                        .HasColumnName("fk_t_blog_publ_id");

                    b.Property<Guid?>("FkTProductoProdId")
                        .HasColumnName("fk_t_producto_prod_id");

                    b.Property<Guid?>("FkTProyProyId")
                        .HasColumnName("fk_t_proy_proy_id");

                    b.Property<string>("ImageName")
                        .HasColumnName("image_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ImageUrl")
                        .HasColumnName("image_url")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("ImageId");

                    b.HasIndex("FkTBlogPublId");

                    b.HasIndex("FkTProductoProdId");

                    b.HasIndex("FkTProyProyId");

                    b.ToTable("t_images");
                });

            modelBuilder.Entity("Domain.TProducto", b =>
                {
                    b.Property<Guid>("ProdId")
                        .HasColumnName("prod_id");

                    b.Property<Guid?>("FkUserUserId")
                        .HasColumnName("fk_user_user_id");

                    b.Property<string>("ProdBrand")
                        .HasColumnName("prod_brand")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProdCod")
                        .HasColumnName("prod_cod")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProdDesc")
                        .HasColumnName("prod_desc")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProdName")
                        .HasColumnName("prod_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProdPrice")
                        .HasColumnName("prod_price")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProdStock")
                        .HasColumnName("prod_stock")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ProdId");

                    b.HasIndex("FkUserUserId");

                    b.ToTable("t_producto");
                });

            modelBuilder.Entity("Domain.TProyectos", b =>
                {
                    b.Property<Guid>("ProyId")
                        .HasColumnName("proy_id");

                    b.Property<Guid?>("FkTUserUserId")
                        .HasColumnName("fk_t_user_user_id");

                    b.Property<DateTime?>("ProyDate")
                        .HasColumnName("proy_date")
                        .HasColumnType("date");

                    b.Property<string>("ProyDesc")
                        .HasColumnName("proy_desc")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<string>("ProyEtiq");

                    b.Property<string>("ProyTitle")
                        .HasColumnName("proy_title")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ProyUrl")
                        .HasColumnName("proy_url")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ProyId");

                    b.HasIndex("FkTUserUserId");

                    b.ToTable("t_proyectos");
                });

            modelBuilder.Entity("Domain.TUser", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id");

                    b.Property<string>("UserAddress")
                        .HasColumnName("user_address")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnName("user_email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnName("user_first_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserGit")
                        .IsRequired()
                        .HasColumnName("user_git")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnName("user_last_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserPhone")
                        .HasColumnName("user_phone")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserPhoto")
                        .HasColumnName("user_photo")
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<string>("UserRole")
                        .HasColumnName("user_role")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserWeb")
                        .HasColumnName("user_web")
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.HasKey("UserId");

                    b.ToTable("t_user");
                });

            modelBuilder.Entity("Domain.TBlog", b =>
                {
                    b.HasOne("Domain.TUser", "FkTUserUser")
                        .WithMany("TBlog")
                        .HasForeignKey("FkTUserUserId")
                        .HasConstraintName("FK_t_blog_t_user1");
                });

            modelBuilder.Entity("Domain.TImages", b =>
                {
                    b.HasOne("Domain.TBlog", "FkTBlogPubl")
                        .WithMany("TImages")
                        .HasForeignKey("FkTBlogPublId")
                        .HasConstraintName("FK_t_images_t_blog");

                    b.HasOne("Domain.TProducto", "FkTProductoProd")
                        .WithMany("TImages")
                        .HasForeignKey("FkTProductoProdId")
                        .HasConstraintName("FK_t_images_t_producto");

                    b.HasOne("Domain.TProyectos", "FkTProyProy")
                        .WithMany("TImages")
                        .HasForeignKey("FkTProyProyId")
                        .HasConstraintName("FK_t_images_t_proyectos");
                });

            modelBuilder.Entity("Domain.TProducto", b =>
                {
                    b.HasOne("Domain.TUser", "FkUserUser")
                        .WithMany("TProducto")
                        .HasForeignKey("FkUserUserId")
                        .HasConstraintName("FK_t_producto_t_user");
                });

            modelBuilder.Entity("Domain.TProyectos", b =>
                {
                    b.HasOne("Domain.TUser", "FkTUserUser")
                        .WithMany("TProyectos")
                        .HasForeignKey("FkTUserUserId")
                        .HasConstraintName("FK_t_proyectos_t_user1");
                });
#pragma warning restore 612, 618
        }
    }
}
