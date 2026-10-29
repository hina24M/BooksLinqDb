using Microsoft.EntityFrameworkCore;

namespace BooksLinqDb.Data
{
    public class BooksDbContext : DbContext
    {
        public string DbPath { get; }

        public DbSet<Book> Books => Set<Book>();

        public BooksDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "books.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book(1, "The C# Programming Language", "Anders Hejlsberg", 2020, 45.99, "Programming"),
                new Book(2, "Entity Framework Core in Action", "Jon P. Smith", 2021, 39.99, "Programming"),
                new Book(3, "Clean Code", "Robert C. Martin", 2008, 30.00, "Software Engineering"),
                new Book(4, "The Pragmatic Programmer", "Andrew Hunt", 2019, 35.50, "Software Engineering"),
                new Book(5, "LINQ in Action", "Marios Skevos", 2009, 29.99, "Programming")
            );
        }
    }
}