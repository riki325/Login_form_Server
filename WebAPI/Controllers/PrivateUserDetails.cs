using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Services;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivateUserDetails : ControllerBase
    {
        private readonly IService<PrivateUserDetailsDTO> _privateUserDetails;
        public PrivateUserDetails(IService<PrivateUserDetailsDTO> privateUserDetailsDTO)
        {
            _privateUserDetails = privateUserDetailsDTO;
        }
        [HttpPost]
         public async Task<PrivateUserDetailsDTO> Post([FromBody] PrivateUserDetailsModel postModel)
        {
            
            PrivateUserDetailsDTO newOne = new PrivateUserDetailsDTO();
            newOne.Id = postModel.Id;
            newOne.FirstName = postModel.FirstName;
            newOne.LastName = postModel.LastName;
            newOne.IdNumber = postModel.IdNumber;
            newOne.DateOfBirth = postModel.DateOfBirth;
            newOne.Genus = postModel.Genus;
            newOne.FamilyId = postModel.FamilyId;
            newOne.Status = postModel.Status;
            newOne.HMO=postModel.HMO;
            newOne.SpouseId=postModel.SpouseId;
            return await _privateUserDetails.Add(newOne);
        }
       
        // GET: api/<PrivateUserDetails>
        [HttpGet]
        public async Task<List<PrivateUserDetailsDTO>> Get()
        {
            return await _privateUserDetails.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<PrivateUserDetailsDTO> Get(int id)
        {
            return await _privateUserDetails.GetById(id);
        }

        


    }
}
