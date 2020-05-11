using FootballStatistics.Domain.Models;
using FootballStatistics.Domain.Services;
using FootballStatistics.EntityFramework.Services.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FootballStatistics.EntityFramework.Services
{
    public class UserDataService : IDataService<User>
    {
        private readonly FootballStatisticsDbContextFactory _context;
        public NonQueryDataService<User> _nonQueryDataService;

        public UserDataService(FootballStatisticsDbContextFactory context)
        {
            _context = context;
            _nonQueryDataService = new NonQueryDataService<User>(context);
        }

        public async Task<User> Create(User entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<User> Get(int id)
        {
            using(FootballStatisticsDbContext context = _context.CreateDbContext())
            {
                User entity = await context.Users
                    .FirstOrDefaultAsync(e => e.Id == id);

                return entity;
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            using(FootballStatisticsDbContext context = _context.CreateDbContext())
            {
                var entities = await context.Users.ToListAsync();

                return entities;
            }
        }

        public async Task<User> GetByEmail(string email)
        {
            using(FootballStatisticsDbContext context = _context.CreateDbContext())
            {
                User entity = await context.Users
                    .FirstOrDefaultAsync(e => e.Email == email);

                return entity;
            }
        }

        public async Task<User> GetByUsername(string username)
        {
            using(FootballStatisticsDbContext context = _context.CreateDbContext())
            {
                User entity = await context.Users
                    .FirstOrDefaultAsync(e => e.Username == username);

                return entity;
            }
        }

        public async Task<User> Update(int id, User entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
