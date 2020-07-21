using HwProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HwProj.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        // _CreatePartial.cshtml
        public CreateTeacherViewModel CreateTeacherViewModel { get; set; }
    }
}