using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Gender
{
    Male, Female, Other
}

namespace CollectionsAndGenerics.Classes
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public Gender StudentGender { get; set; }
    }
}
