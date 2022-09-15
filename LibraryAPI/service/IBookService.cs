using LibraryAPI.Models;

namespace LibraryAPI.service
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Add(Book newBook);
        Book GetById(Guid Id);
        void Remove(Guid Id);



    }
}
