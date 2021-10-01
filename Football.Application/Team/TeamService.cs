using AutoMapper;
using Football.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Team
{
    public interface ITeamService
    {
        void Add(AddTeamDto team);
        void Update(UpdateTeamDto team);
        void Delete(DeleteTeamDto team);
        List<GetTeamDto> GetById(GetTeamDto team);
        List<GetTeamDto> GetAll();
    }
    public class TeamService : ITeamService
    {

        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;
        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }
        public void Add(AddTeamDto team)
        {
            _teamRepository.Add(_mapper.Map<Football.Domain.Entities.Team>(team));
        }

        public void Delete(DeleteTeamDto team)
        {
            _teamRepository.Delete(_mapper.Map<Football.Domain.Entities.Team>(team));
        }
        public void Update(UpdateTeamDto team)
        {
            _teamRepository.Update(_mapper.Map<Football.Domain.Entities.Team>(team));
        }

        public List<GetTeamDto> GetById(GetTeamDto team)
        {
            var query = _teamRepository.GetAll();
            var list = _mapper.Map<List<GetTeamDto>>(query);
            return list.Where(x => x.Id == team.Id).ToList();
        }

        
        public List<GetTeamDto> GetAll()
        {
            var list = _teamRepository.GetAll();
            return _mapper.Map<List<GetTeamDto>>(list);
        }
    }
}
