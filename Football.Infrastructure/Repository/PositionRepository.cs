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
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        public PositionRepository(FootballDbContext DbContext) : base(DbContext)
        {

        }
    }
}
