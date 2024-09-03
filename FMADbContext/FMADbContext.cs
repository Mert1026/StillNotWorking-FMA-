using System.Reflection.Emit;


namespace DbContext
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    public class FMADbContext : DbContext
    {
        public FMADbContext()
        {

        }

        public FMADbContext(DbContextOptions<FMADbContext> options) : base(options)           
        {

        }

        public DbSet<Accounts> Accounts { get; set; } = null!;
        public DbSet<ElementsI> ElementsI { get; set; } = null!;
        public DbSet<ElementsP> ElementsP { get; set; } = null!;
        public DbSet<Income> Incomes { get; set; } = null!;
        public DbSet<IncomeHistory> IncomeHistory { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<PaymentHistory> PaymentHistories { get; set; } = null!;
        public DbSet<TransactionHistory> TransactionHistories { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>().Property(p => p.Ballance).HasPrecision(18,2);
            modelBuilder.Entity<Accounts>().Property(p => p.MonthlyIncome).HasPrecision(18, 2);
            modelBuilder.Entity<ElementsP>().Property(p => p.Price).HasPrecision(18, 2);
            modelBuilder.Entity<Income>().Property(p => p.IncomeBalance).HasPrecision(18, 2);
            modelBuilder.Entity<Payment>().Property(p => p.MoneySpend).HasPrecision(18, 2);
            modelBuilder.Entity<TransactionHistory>().Property(p => p.Balance).HasPrecision(18, 2);
                       
            modelBuilder.Entity<Payment>().Property(p => p.PaymentDate).HasColumnName("PaymentDate");

            base.OnModelCreating(modelBuilder);

        }
    } 
}
