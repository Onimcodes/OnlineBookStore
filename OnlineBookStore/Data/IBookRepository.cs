using OnlineBookStore.Entity;

namespace OnlineBookStore.Api.Data
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBook(int transactionId);
        //Task<Book> AddTransaction(Book transaction);
        //Task<Book> UpdateTransaction(Book transaction);
        //Task DeleteTransaction(int transactionId);
    }
}
