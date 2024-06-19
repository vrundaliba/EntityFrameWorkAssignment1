using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class TypeBase :  BaseEntity
    {
        public string Name { get; set; }
        public Status status { get; set; }
        public string? Description { get; set; }
        


    }
}
