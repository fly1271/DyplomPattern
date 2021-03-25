using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DiplomProject.Domain;

namespace DiplomProject.Models
{
    public class Database : DbContext
    {
        public DbSet<InfoAp> InfoDB { get; set; }
    }
}
