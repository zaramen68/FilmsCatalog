using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Models
{
    public class Film
    {
        /*
        public Film(int id, string name, string description, int year, string director, string userid, byte[] poster)
        {
            Id = id;
            Name = name;
            Description = description;
            Year = year;
            Director = director;
            UserId = userid;
            Poster = poster;
        }
        */

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public byte[] Poster { get; set; }
        

       
    }

    public class PostFilm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }

        public string UserId { get; set; }

       
        

        public IFormFile uploadedFile { get; set; }
    }
}
