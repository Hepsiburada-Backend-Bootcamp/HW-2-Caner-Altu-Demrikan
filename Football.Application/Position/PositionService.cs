using AutoMapper;
using Football.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Position
{
    public interface IPositionService
    {
        void Add(AddPositionDto position);
        void Update(UpdatePositionDto position);
        void Delete(DeletePositionDto position);
        List<GetPositionDto> GetById(GetPositionDto position);
        List<GetPositionDto> GetAll();

    }
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;
        public PositionService(IPositionRepository playerRepository, IMapper mapper)
        {
            _positionRepository = playerRepository;
            _mapper = mapper;
        }

        public void Add(AddPositionDto position)
        {
            _positionRepository.Add(_mapper.Map<Football.Domain.Entities.Position>(position));
        }

        public void Delete(DeletePositionDto position)
        {
            _positionRepository.Delete(_mapper.Map<Football.Domain.Entities.Position>(position));
        }

        public void Update(UpdatePositionDto position)
        {
            _positionRepository.Update(_mapper.Map<Football.Domain.Entities.Position>(position));
        }

        public List<GetPositionDto> GetById(GetPositionDto position)
        {
            var query = _positionRepository.GetAll();
            var list = _mapper.Map<List<GetPositionDto>>(query);
            return list.Where(x => x.Id == position.Id).ToList();
        }
        public List<GetPositionDto> GetAll()
        {
            var list = _positionRepository.GetAll();
            return _mapper.Map<List<GetPositionDto>>(list);
        }


    }
}
