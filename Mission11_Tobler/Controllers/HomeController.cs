using Microsoft.AspNetCore.Mvc;
using Mission11_Tobler.Models;
using Mission11_Tobler.Models.ViewModels;

namespace Mission11_Tobler.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum=1)
        {
            int pageSize = 10;

            var allPages = new ProjectListViewModels
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(allPages);
        }

    }
}
