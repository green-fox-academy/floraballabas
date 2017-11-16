using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NinjaApp.Models;
using NinjaApp.Repositories;

namespace NinjaApp.Services
{
    public class ClanService : IClanService
    {
        private IClanRepository clanRepository;

        public ClanService(IClanRepository clanRepository)
        {
            this.clanRepository = clanRepository;
        }

        public Task<Clan> CreateAsync(Clan clan)
        {
            throw new NotImplementedException();
        }

        public Task<Clan> DeleteAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsClanExistsAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Clan>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Clan> ReadOneAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<Clan> UpdateAsync(Clan clan)
        {
            throw new NotImplementedException();
        }
    }
}
