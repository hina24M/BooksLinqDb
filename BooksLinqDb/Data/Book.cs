using System.ComponentModel.DataAnnotations;

namespace BooksLinqDb.Data
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Book()
        {
            Title = string.Empty;
            Author = string.Empty;
            Category = string.Empty;
        }

        public Book(int id, string title, string author, int publicationYear, double price, string category)
        {
            Id = id;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id}: '{Title}' by {Author} ({PublicationYear}) - £{Price} [{Category}]";
        }
    }
}