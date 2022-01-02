using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Blog.Data
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(string connectionString) : base(connectionString)
        {
            //2.Adım 
        }

        //HerSınıfımızın DbSette tanımlanması lazım
        //DbSet ile tanımlanan her class  Sql'De bir tabloya karşılık gelir ve EF ORM'si tarafında maplenir 
        public virtual DbSet<Category> Categories { get;set;}
        public virtual DbSet<CategoryDetail> CategoryDetails { get; set; }
        public virtual DbSet<CategoryDetailImage> CategoryDetailImages { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        //public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<PageSection> PageSections { get; set; }
        public virtual DbSet<PageSectionContent> PageSectionContents { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<BlogHomePageImage> BlogHomePageImages { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<CategoryDetail>().ToTable("CategoryDetail");
            modelBuilder.Entity<CategoryDetailImage>().ToTable("CategoryDetailImage");
            modelBuilder.Entity<Message>().ToTable("Message");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Slider>().ToTable("Slider");
            //modelBuilder.Entity<UserRole>().ToTable("UserRole");
            modelBuilder.Entity<Tag>().ToTable("Tag");
            modelBuilder.Entity<PageSection>().ToTable("PageSection");
            modelBuilder.Entity<PageSectionContent>().ToTable("PageSectionContent");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<BlogHomePageImage>().ToTable("BlogHomePageImage");
        }

    }
}


