﻿using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EfCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EfCore
{
    public class MBContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }


        public MBContext(DbContextOptions<MBContext> option) : base(option)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
