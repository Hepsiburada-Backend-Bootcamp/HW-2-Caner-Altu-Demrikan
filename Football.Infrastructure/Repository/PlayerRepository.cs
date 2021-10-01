using Football.Domain.Entities;
using Football.Domain.Repository;
using Football.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Infrastructure.Repository
{
    public class PlayerRepository: Repository<Player>, IPlayerRepository
    {
        private readonly FootballDbContext _footballDbContext;
        DbSet<Player> _dbSet;
        public PlayerRepository(FootballDbContext Dbcontext) : base(Dbcontext)
        {
            _footballDbContext = Dbcontext;
            _dbSet = _footballDbContext.Set<Player>();
        }

        public List<Player> GetByAge(int age)
        {
            return _dbSet.Where(x => x.Age == age).ToList();
        }

        public List<Player> GetByLastName(string lastName)
        {
            return _dbSet.Where(x => x.LastName == lastName).ToList();
        }

        public List<Player> GetByName(string name)
        {
            return _dbSet.Where(x => x.Name == name).ToList();
        }

        public List<Player> GetByPositionId(int positionid)
        {
            return _dbSet.Where(x => x.PositionId == positionid).ToList();
        }
        public List<Player> GetByTeamId(int teamid)
        {
            return _dbSet.Where(x => x.TeamId == teamid).ToList();
        }

        public List<Player> GetByPosition(Position position)
        {
            return _dbSet.Where(x => x.Position.Name == position.Name).ToList();
        }

        public List<Player> GetById(int id)
        {
            return _dbSet.Where(x => x.Id == id).ToList();
        }
    }
}
