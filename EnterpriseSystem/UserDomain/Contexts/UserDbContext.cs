using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using UserDomain.Mappings;
using UserDomainContract.DataContract;

namespace UserDomain.Contexts
{
    public class UserDbContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public UserDbContext(IHostingEnvironment env)
        {
            _env = env;
        }

        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserInfoMap());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseMySql(config.GetConnectionString("MySqlConnection"));
        }
    }
}
