using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRapChieuPhim.Entities
{
    public abstract class Entity
    {
        public virtual string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
