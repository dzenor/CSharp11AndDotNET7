using BookStore.Models.Domain;
using BookStore.Repositories.Abstract;

namespace BookStore.Repositories.Implementation
{
    public class AuthorService : IAuthorService
    {
        private readonly DatabaseContext _context;

        public AuthorService(DatabaseContext context)
        {
            _context = context;
        }


        public bool Add(Author model)
        {
            try
            {
                _context.Author.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null)
                    return false;
                _context.Author.Remove(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public Author FindById(int id)
        {
            return _context.Author.Find(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _context.Author.ToList();
        }

        public bool Update(Author model)
        {
            try
            {
                _context.Author.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
