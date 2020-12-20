using AutoMapper;
using MoviesApp.Data;
using MoviesApp.Models;
using MoviesApp.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public class ActorService : IActorService
    {
        private readonly MoviesContext _context;
        private readonly IMapper _mapper;
        public ActorService(MoviesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ActorDto AddActor(ActorDto actorDto)
        {
            var actor = _context.Add(_mapper.Map<Actor>(actorDto)).Entity;
            _context.SaveChanges();
            return _mapper.Map<ActorDto>(actor);
        }

        public ActorDto DeleteActor(int id)
        {
            var actor = _context.Actors.Find(id);
            _context.Actors.Remove(actor);
            _context.SaveChanges();
            return _mapper.Map<ActorDto>(actor);
        }

        public ActorDto GetActor(int id)
        {
            return _mapper.Map<ActorDto>(_context.Actors.FirstOrDefault(m => m.Id == id));
        }

        public IEnumerable<ActorDto> GetAllActors()
        {
            return _mapper.Map<IEnumerable<Actor>, IEnumerable<ActorDto>>(_context.Actors.ToList());
        }

        public ActorDto UpdateActor(ActorDto actorDto)
        {
            var actor = _mapper.Map<Actor>(actorDto);
            _context.Update(actor);
            _context.SaveChanges();
            return _mapper.Map<ActorDto>(actor);
        }
    }
}
