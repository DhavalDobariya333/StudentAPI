using System;
using System.Collections.Generic;

namespace StudentAPI.Model
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = null!;
        public int? RollNo { get; set; }
    }
}
