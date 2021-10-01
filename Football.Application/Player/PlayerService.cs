using AutoMapper;
using Football.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Player
{
    public interface IPlayerService
    {
        void Add(AddPlayerDto player);
        void Update(UpdatePlayerDto player);
        void Delete(DeletePlayerDto player);
        //List<GetPlayerDto> Get(Expression<Func<GetPlayerDto, bool>> filter);
        //List<GetPlayerDto> Get(GetPlayerDto player);
        List<GetPlayerDto> GetAll();
        List<GetPlayerDto> GetById(GetPlayerDto player);
        List<GetPlayerDto> GetByAge(GetPlayerDto player);
        List<GetPlayerDto> GetByName(GetPlayerDto player);
        List<GetPlayerDto> GetByLastName(GetPlayerDto player);
        List<GetPlayerDto> GetByPositionId(GetPlayerDto player);
        List<GetPlayerDto> GetByTeamId(GetPlayerDto player);
    }
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;
        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
         
        public void Add(AddPlayerDto player)
        {
            _playerRepository.Add(_mapper.Map<Football.Domain.Entities.Player>(player));
        }
        
        public void Delete(DeletePlayerDto player)
        {
            _playerRepository.Delete(_mapper.Map<Football.Domain.Entities.Player>(player));
        }
        
        public void Update(UpdatePlayerDto player)
        {
            _playerRepository.Update(_mapper.Map<Football.Domain.Entities.Player>(player));
        }

        /* public List<GetPlayerDto> Get(Expression<Func<GetPlayerDto, bool>> filter)
         {
             var dtoFilter = _mapper.Map<Expression<Func<Football.Domain.Entities.Player, bool>>>(filter);
             var result = _playerRepository.Get(dtoFilter);
             return _mapper.Map<List<GetPlayerDto>>(result);
         }*/
        /*public List<GetPlayerDto> Get(GetPlayerDto player)
        {
            var query = _playerRepository.GetAll();
            var list = _mapper.Map<List<GetPlayerDto>>(query);
            var filtered = list.Where(x =>
                               x.Id.Equals(player.Id != 0 ? player.Id : x.Id) &&
                               x.Name.Equals(player.Name != null ? player.Name : x.Name) &&
                               x.LastName.Equals(player.LastName != null ? player.LastName : x.LastName) &&
                               x.Age.Equals(player.Age != 0 ? player.Age : x.Age) &&
                               x.TeamId.Equals(player.TeamId != 0 ? player.TeamId : x.TeamId) &&
                               x.PositionId.Equals(player.PositionId != 0 ? player.PositionId : x.PositionId)
                                );
            return filtered.ToList();
        }*/
        public List<GetPlayerDto> GetAll()
        {
            var list = _playerRepository.GetAll();
            return _mapper.Map<List<GetPlayerDto>>(list);
        }

        public List<GetPlayerDto> GetById(GetPlayerDto player)
        {
            var result = _playerRepository.GetById(player.Id);
            return _mapper.Map<List<GetPlayerDto>>(result);
        }

        public List<GetPlayerDto> GetByAge(GetPlayerDto player)
        {
            var list = _playerRepository.GetByAge(player.Age);
            return _mapper.Map<List<GetPlayerDto>>(list);
        }
        public List<GetPlayerDto> GetByName(GetPlayerDto player)
        {
            var list = _playerRepository.GetByName(player.Name);
            return _mapper.Map<List<GetPlayerDto>>(list);
        }
        public List<GetPlayerDto> GetByLastName(GetPlayerDto player)
        {
            var list = _playerRepository.GetByLastName(player.LastName);
            return _mapper.Map<List<GetPlayerDto>>(list);
        }
        public List<GetPlayerDto> GetByPositionId(GetPlayerDto player)
        {
            var list = _playerRepository.GetByPositionId(player.PositionId);
            return _mapper.Map<List<GetPlayerDto>>(list);
        }
        public List<GetPlayerDto> GetByTeamId(GetPlayerDto player)
        {
            var list = _playerRepository.GetByTeamId(player.PositionId);
            return _mapper.Map<List<GetPlayerDto>>(list);
        }
    }
}
