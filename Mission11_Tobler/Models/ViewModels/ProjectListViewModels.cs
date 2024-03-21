namespace Mission11_Tobler.Models.ViewModels
{
    public class ProjectListViewModels
    {
        public IQueryable<Book> Books { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
