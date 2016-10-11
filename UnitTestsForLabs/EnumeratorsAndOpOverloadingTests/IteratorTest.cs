using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnumeratorsAndOpOverloading.Classes;
using System.Collections;

namespace UnitTestsForLabs.EnumeratorsAndOpOverloadingTests
{
    [TestClass]
    public class IteratorTest
    {
        private StudentArrayListIT studentList;
        private StudentIT student1, student2;

        [TestInitialize]
        public void SetUp()
        {
            studentList = new StudentArrayListIT
            {
                ID = 1,
                LecturerName = "",
                StudentArrayList = new ArrayList()
            };
            student1 = new StudentIT()
            {
                StudentID = "X001011941",
                StudentName = "Daniel Buckley",
                StudentGender = Genders.Male,
            };
            studentList.AddStudentToList(student1);
        }

        [TestMethod]
        public void IterationOverListWithOneElementTest()
        {
            string result = studentList.IterateOverCollection();
            Assert.AreEqual(result, "Student ID: X001011941 Student Name: Daniel Buckley Student Gender: Male\n");
        }

        [TestMethod]
        public void IterateListWithTwoElements()
        {
            student2 = new StudentIT()
            {
                StudentID = "XXXXXX",
                StudentName = "XXXX XXXX",
                StudentGender = Genders.Female,
            };
            studentList.AddStudentToList(student2);

            string result = studentList.IterateOverCollection();
            Assert.AreEqual(result, "Student ID: X001011941 Student Name: Daniel Buckley Student Gender: Male\n" +
                "Student ID: XXXXXX Student Name: XXXX XXXX Student Gender: Female\n");
    }
    }
}
