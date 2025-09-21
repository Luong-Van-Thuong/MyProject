using Microsoft.EntityFrameworkCore;
using MyProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Data;

namespace MyProject.Browser
{
    public class AppDbContext : DbContext
    {
        public DbSet<SinhVienData> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Lấy đường dẫn đến thư mục gốc của ứng dụng (project)
            string baseDirectory = AppContext.BaseDirectory;

            // Kết hợp đường dẫn gốc với tên file database
            string dbPath = Path.Combine(baseDirectory, "ThuongTest.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            Console.WriteLine($"Database path: {Path.GetFullPath("ThuongTest.db")}");
        }
    
    }
}
