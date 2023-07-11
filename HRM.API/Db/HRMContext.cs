using HRM.API.Configurations;
using HRM.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HRM.API.Db
{
    public class HRMContext : DbContext
    {
        //public HRMContext()
        //{
        //}
        public HRMContext(DbContextOptions<HRMContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

        }
        public class EmployeeDbContextFactory : IDesignTimeDbContextFactory<HRMContext>
        {
            public HRMContext CreateDbContext(string[] args)
            {
                IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var optionsBuilder = new DbContextOptionsBuilder<HRMContext>();
                var conn = config.GetConnectionString("JenkinsDbConn");
                optionsBuilder.UseSqlServer(conn);
                return new HRMContext(optionsBuilder.Options);
            }
        }
    }
}


