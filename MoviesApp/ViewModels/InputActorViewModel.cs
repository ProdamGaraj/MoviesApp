using MoviesApp.Filters;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.ViewModels
{
    public class InputActorViewModel
    {
        [ActorsNameAtribute]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [ActorsNameAtribute]
        public string LastName { get; set; }
    }
}