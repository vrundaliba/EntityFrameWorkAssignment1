using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PostType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BlogStatusType Status { get; set; }
      
    }
}
