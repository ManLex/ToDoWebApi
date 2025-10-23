using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDos.Pesistence
{
    public class DbInitializer
    {
        public static void Initialize (ToDosDbContext context)
        {
            context.Database.EnsureCreated ();
        }
    }
}
