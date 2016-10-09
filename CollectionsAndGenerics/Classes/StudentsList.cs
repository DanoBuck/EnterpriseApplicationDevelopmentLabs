using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics.Classes
{
    public class StudentsList
    {
        public int ID { get; set; }
        public string LecturerName { get; set; }
        public ArrayList StudentArrayList { get; set; }

        public StudentsList()
        {
            ID = 0;
            LecturerName = "";
            StudentArrayList = new ArrayList();
        }

        public bool AddStudentToList(Student newStudent)
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
                foreach(Student s in StudentArrayList)
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
        public Student this[int i]
        {
            get
            {
                if(i > StudentArrayList.Count)
                {
                    throw new IndexOutOfRangeException("Index out of bounds!");
                }
                else
                {
                    // Cast the Student that is found
                    return (Student) StudentArrayList[i];
                }
            }
        }

        public Student this[string studentId]
        {
            get
            {
                bool hasBeenFound = false;
                Student foundStudent = null;
                foreach (Student sa in StudentArrayList)
                {
                    if(sa.StudentID == studentId)
                    {
                        hasBeenFound = true;
                        foundStudent = sa;
                    }
                }
                // Throw an exception if the student is not found
                if(hasBeenFound == false)
                {
                    throw new IndexOutOfRangeException("Student not found!");
                }
                return foundStudent;
            }
        }
    }
}
