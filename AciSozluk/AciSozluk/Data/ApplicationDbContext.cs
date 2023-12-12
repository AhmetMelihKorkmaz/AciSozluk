using System;
using System.Collections.Generic;
using System.Text;
using AciSozluk.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AciSozluk.Data
{
    public class ApplicationDbContext : IdentityDbContext<AciSozlukUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AciSozluk.Models.PostGroup> PostGroup { get; set; }
        public DbSet<AciSozluk.Models.Post> Post { get; set; }
        public DbSet<AciSozluk.Models.Comment> Comment { get; set; }
        public DbSet<AciSozluk.Models.Like> Like { get; set; }
    }
}
