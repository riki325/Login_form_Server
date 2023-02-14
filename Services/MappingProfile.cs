using AutoMapper;
using Common.DTOs;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<PrivateUserDetails, PrivateUserDetailsDTO>().ReverseMap();
        }
    }
}
