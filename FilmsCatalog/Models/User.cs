using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmsCatalog.Models
{
    public class User : IdentityUser
    {
       

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        //public List<Film> Films { get; set; }
    }
}