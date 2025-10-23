using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDos.Domain
{
    public class ToDo
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime TimeToDone { get; set; }
        public DateTime DateCreateTask { get; set; }

    }
}
