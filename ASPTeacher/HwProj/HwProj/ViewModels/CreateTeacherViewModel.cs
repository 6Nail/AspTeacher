using HwProj.Models;
using System.Collections.Generic;

namespace HwProj.ViewModels
{
    public class CreateTeacherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}