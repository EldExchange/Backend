using EldExchange.Domain.Models.DALs;
using EldExchange.Infra.Context.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EldExchange.Infra.Context
{
    public class EldDbContext : DbContext
    {
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Safe> Safe { get; set; }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<BankNote> BankNotes { get; set; }
        public EldDbContext(DbContextOptions options) : base(options)
        {
            Agencies = Set<Agency>();
            Addresses = Set<Address>();
            Telephones = Set<Telephone>();
            Currencies = Set<Currency>();
            Safe = Set<Safe>();
            Coins= Set<Coin>();
            BankNotes= Set<BankNote>(); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("EldExchange");
            modelBuilder.ApplyConfiguration(new AgencyMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new TelephoneMap());
            modelBuilder.ApplyConfiguration(new CurrencyMap());
            modelBuilder.ApplyConfiguration(new MoneyMap());
            modelBuilder.ApplyConfiguration(new BankNoteMap());
            modelBuilder.ApplyConfiguration(new CoinMap());
            modelBuilder.ApplyConfiguration(new SafeMap());
        }
    }
}
