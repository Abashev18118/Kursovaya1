using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Contekst : DbContext
    {
        private string _connectionString;

        public Contekst(string connectionString = "Host=localhost; Database=kurs; Username=postgres; Password=27lopare")
        {
            _connectionString = connectionString;
        }

        public DbSet<Client> clients { get; set; }
        public DbSet<Composition_of_the_order> compositions { get; set; }
        public DbSet<Dish> dishes { get; set; }
        public DbSet<Menu> menues { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Restaurant> restaurant { get; set; }
        public DbSet<Restaurant_hall> halls { get; set; }
        public DbSet<Table> tables { get; set; }
        public DbSet<Waiter> waiters { get; set; }
        public DbSet<Waiter_s_schedule> shedules { get; set; }
        public DbSet<Waiter_s_schedule1> shedules1 { get; set; }
        public DbSet<Customer_Order> Customer_Orders { get; set; }
        public DbSet<Dish_margin_of_dish> Dish_Margin_Of_Dishes { get; set; }
        public DbSet<Menu_Mark_up_of_dish> Menu_Mark_Up_Of_Dishes { get; set; }
        public DbSet<Waiter_Table> Waiter_Tables { get; set; }
        public DbSet<Mark_up_of_the_dish> mark_Up_Of_The_Dishes { get; set; }
        public DbSet<Newhall> newhalls { get; set; } // Добавлено

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant_hall>()
                .HasOne(e => e.Waiter_s_schedule)
                .WithOne(e => e.Restaurant_hall)
                .HasForeignKey<Waiter_s_schedule>(e => e.Restaurant_hallid)
                .IsRequired();
        }
    }
}