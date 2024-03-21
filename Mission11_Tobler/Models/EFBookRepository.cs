using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mission11_Tobler.Models;

public class EFBookRepository : IBookRepository
{
    private readonly BookstoreContext _context;
    public EFBookRepository(BookstoreContext context)
    {
        _context = context;
    }

    public IQueryable<Book> Books => _context.Books;

    ////public IEnumerable<Book> GetAllBooks()
    ////{
    ////// Use the .Select() method to project the Bowler entities into BowlerDto objects
    ////    var books = _context.Book
    ////    return books;
    ////}
}
