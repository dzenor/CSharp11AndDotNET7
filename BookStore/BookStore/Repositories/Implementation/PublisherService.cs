using BookStore.Models.Domain;
using BookStore.Repositories.Abstract;

namespace BookStore.Repositories.Implementation
{
    public class PublisherService : IPublisherService
    {
        private readonly DatabaseContext _context;

        public PublisherService(DatabaseContext context)
        {
            _context = context;
        }


        public bool Add(Publisher model)
        {
            try
            {
                _context.Publisher.Add(model);
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
                _context.Publisher.Remove(data);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public Publisher FindById(int id)
        {
            return _context.Publisher.Find(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _context.Publisher.ToList();
        }

        public bool Update(Publisher model)
        {
            try
            {
                _context.Publisher.Update(model);
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
