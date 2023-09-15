using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Entity;

namespace OnlineBookStore.Api.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Book> GetBook(int transactionId)
        {
            return await appDbContext.Books.FirstOrDefaultAsync(t => t.Id == transactionId);

        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await appDbContext.Books.ToListAsync();
        }
    }
}
