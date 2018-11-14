using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProgrammingJokeService.Controllers;

namespace ProgrammingJokeService.Models
{
    public class JokeDBContext : DbContext
    {
        public JokeDBContext(DbContextOptions<JokeDBContext> options): base(options)
        {
        }

        public virtual DbSet <Joke> Jokes { get; set; }

    }
}
