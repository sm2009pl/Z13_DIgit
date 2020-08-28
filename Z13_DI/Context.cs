using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z13_DI
{
    public class Context : DbContext
    {
        public DbSet<Model> Models { get; set; }
        public Context()
        {
            Models.Add(new Model() { Amount = 5, Text = "text" });
        }
    }
}
