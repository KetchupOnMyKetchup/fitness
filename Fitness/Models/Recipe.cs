using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness.Models
{
    public class Recipe
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }

//        public List<String> Photos { get; set; }

        public String Ingredients { get; set; }

        public String Directions { get; set; }

    }
}