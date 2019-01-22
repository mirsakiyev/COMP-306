using BookServiceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookServiceAPI.Services
{
    public interface IBookChaptersService
    {
        Task AddAsync(BookChapter chapter);
        Task AddRangeAsync(IEnumerable<BookChapter> chapters);
        Task<BookChapter> RemoveAsync(Guid id);
        Task<IEnumerable<BookChapter>> GetAllAsync();
        Task<BookChapter> FindAsync(Guid id);
        Task UpdateAsync(BookChapter chapter);
    }
}
