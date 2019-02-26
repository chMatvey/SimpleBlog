using System;

namespace Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int PostId { get; set; }
        public DateTime CreateData { get; set; }
    }
}
