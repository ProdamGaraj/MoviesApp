using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;
using MoviesApp.Models;
using MoviesApp.Services;
using MoviesApp.Services.Dto;
using MoviesApp.ViewModels;

namespace MoviesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsApiController : ControllerBase
    {
        private readonly IActorService _service;

        public ActorsApiController(IActorService service, IMapper mapper)
        {
            _service = service;
        }

        // GET: api/ActorsApi
        [HttpGet]
        public ActionResult<IEnumerable<ActorDto>> GetActors()
        {
            return Ok(_service.GetAllActors());
        }

        // GET: api/ActorsApi/5
        [HttpGet("{id}")]
        public ActionResult<Actor> GetActor(int id)
        {
            var actor = _service.GetActor((int)id);

            if (actor == null)
            {
                return NotFound();
            }

            return Ok(actor);
        }

        // PUT: api/ActorsApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutActor(int id, ActorDto editDto)
        {

            var actor = _service.UpdateActor(editDto);
            actor.Id = id;
          
                if (actor==null)
                {
                    return NotFound();
                }

            return NoContent();
        }

        // POST: api/ActorsApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<ActorViewModel> PostActor(ActorDto inputDto)
        {
            var actor = _service.AddActor(inputDto);

            return CreatedAtAction("GetActor", new { id = actor.Id }, actor);
        }

        // DELETE: api/ActorsApi/5
        [HttpDelete("{id}")]
        public ActionResult<Actor> DeleteActor(int id)
        {
            var actor = _service.DeleteActor(id);
            if (actor == null)
            {
                return NotFound();
            }
            return Ok(actor);
        }
    }
}