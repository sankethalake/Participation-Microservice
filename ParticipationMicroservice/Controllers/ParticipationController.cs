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
        // GET: api/Participation/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Participation participation = _dataRepository.Get(id);
            if (participation == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
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
            return CreatedAtRoute(
                  "Get",
                  new { Id = participation.ParticipationId },
                  participation);
        }

        // PUT: api/Participation/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] string status)
        {
            
            Participation participationToUpdate = _dataRepository.Get(id);
            if (participationToUpdate != null && Enum.IsDefined(typeof(ParticipationStatus), status))
            {
                _dataRepository.Update(participationToUpdate, status);
                return Ok(participationToUpdate);
                
            }
            if (!Enum.IsDefined(typeof(ParticipationStatus), status)) ;
            {
                return BadRequest("Select Valid Status");
            }
            return NotFound("The Employee record couldn't be found.");
        }
       
    }
}
