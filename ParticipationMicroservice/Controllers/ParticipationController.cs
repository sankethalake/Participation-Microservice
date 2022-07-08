using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParticipationMicroservice.Model;
using ParticipationMicroservice.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParticipationMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        private readonly IDataRepository<Participation> _dataRepository;
        public ParticipationController(IDataRepository<Participation> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: api/Participation
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Participation> participation = _dataRepository.GetAll();
            return Ok(participation);
        }

        // GET: api/Participation/getPendingParticipations
        [HttpGet("getPendingParticipations/{status}", Name = "GetByPending")]
        public IActionResult GetByPending(string status)
        {
            IEnumerable<Participation> participation = _dataRepository.GetByStatus(status);
            return Ok(participation);
        }

        // GET: api/Participation/getApprovedParticipations 
        [HttpGet("getApprovedParticipations/{status}", Name = "GetByApproved")]
        public IActionResult GetByApproved(string status)
        {

            IEnumerable<Participation> participation = _dataRepository.GetByStatus(status);
            return Ok(participation);
        }

        // GET: api/Participation/GetByDeclined 
        [HttpGet("getDeclinedParticipations/{status}", Name = "GetByDeclined")]
        public IActionResult GetByDeclined(string status)
        {

            IEnumerable<Participation> participation = _dataRepository.GetByStatus(status);
            return Ok(participation);
        }


        // POST: api/Participation
        [HttpPost]
        public IActionResult Post([FromBody] Participation participation)
        {
            if (participation == null)
            {
                return BadRequest("Employee is null.");
            }
            _dataRepository.Add(participation);
            return Ok(participation);
        }


        // PUT: api/Participation/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] string status)
        {
            Participation participationToUpdate = _dataRepository.Get(id);
            if(!_dataRepository.Update(participationToUpdate, status))
            {
                return BadRequest("Select Valid Status");
            }           
            return Ok();


            //if (participationToUpdate != null ))
            //{
            //    _dataRepository.Update(participationToUpdate, status);
            //    return Ok(participationToUpdate);
                
            //}
 
            //return NotFound("The Employee record couldn't be found.");
        }

    }
}
