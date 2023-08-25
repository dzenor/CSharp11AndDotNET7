using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public class RaceRepository : IRaceRepository
    {
        private readonly AplicationDbContext _db;

        public RaceRepository(AplicationDbContext context)
        {

            _db = context;
        }

        public bool Add(Race race)
        {
            _db.Add(race);

            return Save();
        }

        public bool Delete(Race race)
        {
            _db.Remove(race);
            return Save();
        }

        public async Task<IEnumerable<Race>> GetAll()
        {

            return await _db.Races.ToListAsync();
        }

        public async Task<IEnumerable<Race>> GetAllRacesByCity(string city)
        {
            return await _db.Races.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public Task<Race> GetByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Race> GetByIdAsync(int id)
        {

            return await _db.Races.Include(i => i.Address).FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Race race)
        {
            _db.Update(race);
            return Save();
        }

        Task<IEnumerable<Club>> IRaceRepository.GetAllRacesByCity(string city)
        {
            throw new NotImplementedException();
        }

      
    }
}
