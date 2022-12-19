using Microsoft.EntityFrameworkCore;

namespace Company.Crm.Entityframework
{
    //AppDbContext configuration dosyasıyla veri tabanıyla bağlantı kuruyoruz. DbContext ile bu configuration dosyasını kullanabiliriz. DbContext sınıfını kalıtım alıyor. Bu da bir paket ile geliyordu. EntityFrameworkCore ve EntityFrameworkCore.SqlServer paketlerini kurarak bağlantımızı kurabiliriz.
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        //SqlServer ve bağlantı metnini appsettings içerisinden alarak Program.cs içerisnde konfigre ediyoruz.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) // bu satırı program.cs te configure etmek istersek ekleyebiliriz. program.cs e gidip bunu doldurcağız.
        {

        }

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Gender> Genders { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<StatusType> StatusTypes { get; set; }
        //public DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // Program.cs içerisinde DbContext tanımı aşağıdaki gibi olursa;
            // builder.Services.AddDbContext<AppDbContext>()
            // Buradaki konfigrasyon çalışacaktır.
            if (!builder.IsConfigured) //eğer daha önce configure edilmediyse burası çalışsın.
            {        
                 var connectionString = "Server=(localdb)\\MsSqlLocalDb;Database=SF2_CRM_Deneme;Trusted_Connection=True;";
                 builder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
