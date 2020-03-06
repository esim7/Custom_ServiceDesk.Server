using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ServiceDesk.Domain;
using System;
using System.IO;

namespace ServiceDesk.DataAccess
{
    public class DeskContext : DbContext
    {
        private readonly string connectionString;

        public DeskContext()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            this.connectionString = config.GetConnectionString("DebugConnectionString");
            Database.EnsureCreated();
        }

        public DbSet<Request> Requests { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
