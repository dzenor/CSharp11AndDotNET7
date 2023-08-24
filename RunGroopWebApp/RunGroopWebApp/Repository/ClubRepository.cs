using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public class ClubRepository : IClubRepository
    {

        private readonly AplicationDbContext _db;

        public ClubRepository(AplicationDbContext context ) 
        { 
        
            _db = context;
        } 


        public bool Add(Club club)
        {
            _db.Add( club );

            return Save();
        }

        public bool Delete(Club club)
        {
           _db.Remove( club );
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
           return await _db.Clubs.ToListAsync();
        }

        public async Task<Club> GetByAsync(int id)
        {
            return await _db.Clubs.Include(i => i.Address).FirstOrDefaultAsync(i => i.Id == id);
        }

      

        public async Task<IEnumerable<Club>> GetClubByCity(string city)
        {
            return await _db.Clubs.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
         var saved = _db.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Club club)
        {
           _db.Update( club );
            return Save();
        }
    }
}
