using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context {
    public class ContextFactory : IDesignTimeDbContextFactory<DataContext> {
        public DataContext CreateDbContext(string[] args) {
            var connectionString = "Host=localhost;Port=5432;Database=academicoapi;Username=postgres;Password=fanta123";
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new DataContext(optionsBuilder.Options);
        }
    }
}
