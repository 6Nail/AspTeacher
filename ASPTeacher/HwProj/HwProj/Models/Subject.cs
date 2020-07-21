using System.Collections.Generic;

namespace HwProj.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}