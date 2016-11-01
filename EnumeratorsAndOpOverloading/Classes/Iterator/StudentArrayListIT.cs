using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndOpOverloading.Classes
{
    public class StudentArrayListIT
    {
        public int ID { get; set; }
        public string LecturerName { get; set; }
        public ArrayList StudentArrayList { get; set; }

        public StudentArrayListIT()
        {
            ID = 0;
            LecturerName = "";
            StudentArrayList = new ArrayList();
        }

        public bool AddStudentToList(StudentIT newStudent)
        {
            bool hasBeenAdded = false;

            if (StudentArrayList.Count == 0)
            {
                StudentArrayList.Add(newStudent);
                hasBeenAdded = true;
            }
            else
            {
                // Search if ID already exists
                foreach (StudentIT s in StudentArrayList)
                {
                    if (s.StudentID == newStudent.StudentID)
                    {
                        hasBeenAdded = false;
                        throw new Exception("This StudentID already exists!");
                    }
                }
                // Add the new student
                StudentArrayList.Add(newStudent);
                hasBeenAdded = true;
            }
            return hasBeenAdded;
        }

        // Indexers
        public StudentIT this[int i]
        {
            get
            {
                if (i > StudentArrayList.Count)
                {
                    throw new ArgumentOutOfRangeException("Index out of bounds!");
                }
                else
                {
                    // Cast the Student that is found
                    return (StudentIT)StudentArrayList[i];
                }
            }
        }

        public StudentIT this[string studentId]
        {
            get
            {
                bool hasBeenFound = false;
                StudentIT foundStudent = null;
                foreach (StudentIT sa in StudentArrayList)
                {
                    if (sa.StudentID == studentId)
                    {
                        hasBeenFound = true;
                        foundStudent = sa;
                    }
                }
                // Throw an exception if the student is not found
                if (hasBeenFound == false)
                {
                    throw new ArgumentOutOfRangeException("Student not found!");
                }
                return foundStudent;
            }
        }

        public string IterateOverCollection()
        {
            string valueInArray = "";
            foreach(StudentIT s in StudentArrayList)
            {
                valueInArray += "Student ID: " + s.StudentID + 
                    " Student Name: " + s.StudentName +
                    " Student Gender: " + s.StudentGender + "\n";
            }
            return valueInArray;
        }
    }
}
