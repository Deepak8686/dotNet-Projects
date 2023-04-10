using Employee1.Interface;
using Employee1.Modal;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Employee1.Data
{
    public class Empcontext : DbContext
    {
        public Empcontext(DbContextOptions<Empcontext> options) : base(options)
        {
        }
        public DbSet<Employeeclass> employee1 { get; set; }
    }
}
