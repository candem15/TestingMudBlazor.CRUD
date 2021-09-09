using System;
using TestingMudBlazor.CRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace TestingMudBlazor.CRUD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}