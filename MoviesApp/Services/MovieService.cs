using AutoMapper;
using MoviesApp.Data;
using MoviesApp.Models;
using MoviesApp.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesApp.Services
{
    public class MovieService : IMovieService
    {
        private readonly MoviesContext _context;
        private readonly IMapper _mapper;

        public MovieService(MoviesContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public MovieDto AddMovie(MovieDto movieDto)
        {
            var movie = _context.Add(_mapper.Map<Movie>(movieDto)).Entity;
            _context.SaveChanges();
            return _mapper.Map<MovieDto>(movie);
        }

        public MovieDto DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return _mapper.Map<MovieDto>(movie);
        }

        public IEnumerable<MovieDto> GetAllMovies()
        {
            return _mapper.Map<IEnumerable<Movie>, IEnumerable<MovieDto>>(_context.Movies.ToList());
        }

        public MovieDto GetMovie(int id)
        {
            return _mapper.Map<MovieDto>(_context.Movies.FirstOrDefault(m => m.Id == id));
        }

        public MovieDto UpdateMovie(MovieDto movieDto)
        {
            var movie = _mapper.Map<Movie>(movieDto);
            _context.Update(movie);
            _context.SaveChanges();
            return _mapper.Map<MovieDto>(movie);
        }
    }
}
