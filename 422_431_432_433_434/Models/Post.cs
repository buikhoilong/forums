using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _422_431_432_433_434.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateTimePost { get; set; }
        public DateTime DateTimeEdit { get; set; }
        public int TopicID { get; set; }
        public int AccountID { get; set; }
        public bool Status { get; set; }



    }
}
