using Football.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Domain.Repository
{
    public interface IPlayerRepository : IRepository<Player>
    {
        List<Player> GetById(int id);
        List<Player> GetByAge(int age);
        List<Player> GetByName(string name);
        List<Player> GetByLastName(string lastName);
        List<Player> GetByPositionId(int positionid);
        List<Player> GetByTeamId(int teamid);
        List<Player> GetByPosition(Position position);
    }
}
