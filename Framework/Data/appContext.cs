using Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Framework.Data
{
    public class appContext: DbContext
    {
        public appContext(DbContextOptions<appContext>options): base(options)
        {

        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
