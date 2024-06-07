using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post : BaseEntity
    { 
        public string Title { get; set; }
        public string content { get; set; }
       
        public int BlogId { get; set; }
        public int PostTypeId { get; set; }
        public int UserId { get; set; }

        public Blog Blog { get; set; }
        public PostType PostType { get; set; }
        public User Users{ get; set; }
    }
}

