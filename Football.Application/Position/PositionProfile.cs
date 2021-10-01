using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Position
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<AddPositionDto, Football.Domain.Entities.Position>().ReverseMap();
            CreateMap<UpdatePositionDto, Football.Domain.Entities.Position>().ReverseMap();
            CreateMap<DeletePositionDto, Football.Domain.Entities.Position>().ReverseMap();
            CreateMap<GetPositionDto, Football.Domain.Entities.Position>().ReverseMap();
        }
    }
}
