using MoviesApp.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Services
{
    public interface IActorService
    {
        ActorDto GetActor(int id);
        IEnumerable<ActorDto> GetAllActors();
        ActorDto UpdateActor(ActorDto movieDto);
        ActorDto AddActor(ActorDto movieDto);
        ActorDto DeleteActor(int id);
    }
}
