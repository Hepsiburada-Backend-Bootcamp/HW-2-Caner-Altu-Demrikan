using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Team
{
    public class TeamProfile : Profile
    {
        public TeamProfile() 
        {
            CreateMap<AddTeamDto, Football.Domain.Entities.Team>().ReverseMap();
            CreateMap<UpdateTeamDto, Football.Domain.Entities.Team>().ReverseMap();
            CreateMap<DeleteTeamDto, Football.Domain.Entities.Team>().ReverseMap();
            CreateMap<GetTeamDto, Football.Domain.Entities.Team>().ReverseMap();

        }
        

    }
}
