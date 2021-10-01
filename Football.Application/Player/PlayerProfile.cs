using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Player
{
    public class PlayerProfile:Profile
    {
        public PlayerProfile()
        {
            CreateMap<AddPlayerDto, Football.Domain.Entities.Player>().ReverseMap();
            CreateMap<UpdatePlayerDto, Football.Domain.Entities.Player>().ReverseMap();
            CreateMap<DeletePlayerDto, Football.Domain.Entities.Player>().ReverseMap();
            CreateMap<GetPlayerDto, Football.Domain.Entities.Player>().ReverseMap();
            CreateMap<Expression<Func<Football.Domain.Entities.Player,bool>>, Expression<Func<GetPlayerDto, bool>>>().ReverseMap();
            
        }

    }
}
 