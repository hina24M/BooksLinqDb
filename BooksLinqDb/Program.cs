using BooksLinqDb.Data;

using var db = new BooksDbContext();

// 1. Display all books
var allBooks = db.Books.ToList();
Console.WriteLine("--- All Books in Database ---");
foreach (var book in allBooks)
{
    Console.WriteLine(book);
}

// 2. LINQ Query: Find books in the "Programming" category
var programmingBooks = db.Books
    .Where(b => b.Category == "Programming")
    .ToList();

Console.WriteLine("\n--- Programming Books ---");
foreach (var book in programmingBooks)
{
    Console.WriteLine(book);
}

// 3. LINQ Query: Books published after 2015, ordered by price
var recentBooks = db.Books
    .Where(b => b.PublicationYear > 2015)
    .OrderByDescending(b => b.Price)
    .ToList();

Console.WriteLine("\n--- Books Published After 2015 (Highest Price First) ---");
foreach (var book in recentBooks)
{
    Console.WriteLine(book);
}