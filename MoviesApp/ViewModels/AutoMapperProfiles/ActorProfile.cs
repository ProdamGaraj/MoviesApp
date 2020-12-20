using AutoMapper;
using MoviesApp.Models;
using MoviesApp.Services.Dto;

namespace MoviesApp.ViewModels
{
    public class ActorProfile:Profile
    {
        public ActorProfile()
        {
            CreateMap<ActorDto, InputActorViewModel>().ReverseMap();
            CreateMap<ActorDto, DeleteActorViewModel>();
            CreateMap<ActorDto, EditActorViewModel>().ReverseMap();
            CreateMap<ActorDto, ActorViewModel>();
        }
    }
}
