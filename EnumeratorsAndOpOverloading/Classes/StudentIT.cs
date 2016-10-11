using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Genders
{
    Male, Female, Other
}

namespace EnumeratorsAndOpOverloading.Classes
{
    public class StudentIT
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public Genders StudentGender { get; set; }
    }
}
