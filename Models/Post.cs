using System;
using System.Collections.Generic;

namespace Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
