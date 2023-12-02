﻿using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data;

public class ItemDbContext(DbContextOptions<ItemDbContext> options): DbContext(options)
{
    public DbSet<Item> Items { get; set;}
    public DbSet<Record> Records { get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            base.OnModelCreating(modelBuilder);
    }
}

