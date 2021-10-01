using Football.Domain.Entities;
using Football.Domain.Repository;
using Football.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Infrastructure.Repository
{
    public class TeamRepository : Repository<Team> , ITeamRepository
    {
        private readonly FootballDbContext _dbContext;
        public TeamRepository(FootballDbContext Dbcontext) : base(Dbcontext)
        {
            _dbContext = Dbcontext;
        }

    }
}
