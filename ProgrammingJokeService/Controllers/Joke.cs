using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingJokeService.Controllers
{
    /// <summary>
    /// Represents a single programming joke
    /// </summary>
    public class Joke
    {
        [Key]
        public int JokeId { get; set; }

        /// <summary>
        /// The actual text of the joke
        /// </summary>
        public string JokeText { get; set; }
        
        /// <summary>
        /// Category of joke. Ex. C# database programming etc.
        /// </summary>
        
        public string Category { get; set; }
        // Allows end user to type in any category name


    }
}
