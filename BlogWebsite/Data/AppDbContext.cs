﻿using BlogWebsite.Models.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace BlogWebsite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tags> Tags { get; set; }
    }
}
