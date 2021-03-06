﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoStore.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public byte NumberInStock { get; set; }
    }
}