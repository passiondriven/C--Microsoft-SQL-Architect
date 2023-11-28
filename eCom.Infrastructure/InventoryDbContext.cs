using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCom.Infrastructure.Persistance.Repositories;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace eCom.Infrastructure.Persistance
{
    public class InventoryDbContext : DbContext
    {

        public InventoryDbContext() : base()
        {
            //Database.EnsureCreated();
        }

        static void Main(string[] args)
        {


        }

    }

}