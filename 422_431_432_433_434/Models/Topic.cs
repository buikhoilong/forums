using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _422_431_432_433_434.Models
{
    public class Topic
    {
        public int TopicID { get; set; }
        public string Title { get; set; }
        public DateTime DatetimeCreate { get; set; }
        public DateTime LastTimeEdit { get; set; }
        public string Description { get; set; }
        public int AccountID { get; set; }
        public bool Status { get; set; }
    }
}
