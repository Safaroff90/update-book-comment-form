using _Pustok.Models;

namespace _Pustok.ViewModels
{
    public class BookDetailViewModel
    {
        public Book Book { get; set; }
        public List<Book> RelatedBooks { get; set; }
        public ReviewCreateViewModel ReviewVM { get; set; }
    }
}
