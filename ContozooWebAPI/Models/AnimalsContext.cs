using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContozooWebAPI.Models;


    public class AnimalsContext : DbContext
    {
        public AnimalsContext(DbContextOptions<AnimalsContext> options) : base(options)
        {}
        public DbSet<ContozooWebAPI.Models.Animals> Animals{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

        }
    }

