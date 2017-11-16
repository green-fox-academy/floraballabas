using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NinjaApp.Models;

namespace NinjaApp.Repositories
{
    public class ClanRepository : IClanRepository
    {
        private readonly List<Clan> clans;

        public ClanRepository(IEnumerable<Clan> clans)
        {
            if (clans == null) { throw new ArgumentNullException(nameof(clans)); }
            this.clans = new List<Clan>(clans);
        }

        public Task<Clan> CreateAsync(Clan clan)
        {
            throw new NotImplementedException();
        }

        public Task<Clan> DeleteAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Clan>> ReadAllAsync()
        {
            return Task.FromResult(clans.AsEnumerable());
        }

        public Task<Clan> ReadOneAsync(string clanName)
        {
            var clan = clans.FirstOrDefault(c => c.Name == clanName);
            return Task.FromResult(clan);
        }

        public Task<Clan> UpdateAsync(Clan clan)
        {
            throw new NotImplementedException();
        }
    }
}
