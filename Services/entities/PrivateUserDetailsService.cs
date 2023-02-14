using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common.DTOs;
using Repositories.Entities;
using Repositories.Interfaces;

namespace Services.entities
{
    public class PrivateUserDetailsService : IService<PrivateUserDetailsDTO>
    {
        private readonly IMapper _mapper;
        private readonly IDataRepository<PrivateUserDetails> _privateUserDetails;
        private static int FamilyIdCode = 1;
        public PrivateUserDetailsService(IMapper mapper, IDataRepository<PrivateUserDetails> privateUserDetailsRepository)
        {
            _mapper = mapper;
            _privateUserDetails = privateUserDetailsRepository;
        }
        public async Task<PrivateUserDetailsDTO> Add(PrivateUserDetailsDTO entity)
        {
            var users = await GetAll();
            
            var res = users.FirstOrDefault(x => x.SpouseId == entity.IdNumber);
            if (res == null)
                entity.FamilyId = FamilyIdCode++;
            else
                entity.FamilyId = res.FamilyId;
            return _mapper.Map<PrivateUserDetailsDTO>(await _privateUserDetails.AddAsync(_mapper.Map<PrivateUserDetails>(entity)));
        }

        public async Task<List<PrivateUserDetailsDTO>> GetAll()
        {
            return _mapper.Map <List<PrivateUserDetailsDTO>>(await _privateUserDetails.GetAllAsync());
        }

        public async Task<PrivateUserDetailsDTO> GetById(int id)
        {
            return _mapper.Map<PrivateUserDetailsDTO>(await _privateUserDetails.GetByIdAsync(id));
        }



    }
}
