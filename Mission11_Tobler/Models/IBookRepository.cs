using System.Collections.Generic;
using System.Threading.Tasks;
using Mission11_Tobler.Models;

namespace Mission11_Tobler.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
