using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sirbu_Iulia_Lab5.Models;

namespace Sirbu_Iulia_Lab5.Data
{
    public class Sirbu_Iulia_Lab5Context : DbContext
    {
        public Sirbu_Iulia_Lab5Context (DbContextOptions<Sirbu_Iulia_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Sirbu_Iulia_Lab5.Models.Expenses> Expenses { get; set; } = default!;
        public DbSet<Sirbu_Iulia_Lab5.Models.ExpenseDTO> ExpenseDTO { get; set; }

    }
}
