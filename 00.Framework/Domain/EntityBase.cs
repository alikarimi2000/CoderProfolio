using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Framework.Domain
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
