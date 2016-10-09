using CollectionsAndGenerics.Classes;
using CollectionsAndGenerics.ClassesUsingListInstead;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestsForLabs.CollectionsAndGenericsTests.ListTests
{
    [TestClass]
    public class ListTests
    {
        private ListOfStudentsRevised studentList;
        private Student newStudent, newStudent2;

        [TestInitialize]
        public void SetUp()
        {
            newStudent = new Student
            {
                StudentID = "X00101941",
                StudentName = "Daniel Buckley",
                StudentGender = Gender.Male
            };
            newStudent2 = new Student
            {
                StudentID = "X1111111",
                StudentName = "New Student",
                StudentGender = Gender.Female
            };
            studentList = new ListOfStudentsRevised()
            {
                ID = 0,
                LecturerName = "Lecturer",
                StudentArrayList = new List<Student>()
            };
        }

        [TestMethod]
        public void AddStudentToArrayListTest()
        {
            bool result = studentList.AddStudentToList(newStudent);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddTwoStudentsToArrayListTest()
        {
            studentList.AddStudentToList(newStudent);
            studentList.AddStudentToList(newStudent2);
            Assert.AreEqual(studentList.StudentArrayList.Count, 2);
        }

        [TestMethod]
        public void AddStudentToArrayListTestShouldThrowException()
        {
            try
            {
                studentList.AddStudentToList(newStudent);
                studentList.AddStudentToList(newStudent);
                Assert.Fail("Should fail on double studentId");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is Exception);
            }
        }

        [TestMethod]
        public void TestIntIndexer()
        {
            studentList.AddStudentToList(newStudent);
            studentList.AddStudentToList(newStudent2);
            Student s = studentList[0];
            Assert.AreEqual(s.StudentID, "X00101941");
            Assert.AreEqual(s.StudentName, "Daniel Buckley");
            Assert.AreEqual(s.StudentGender, Gender.Male);
        }

        [TestMethod]
        public void TestIntIndexerWithException()
        {
            try
            {
                studentList.AddStudentToList(newStudent);
                studentList.AddStudentToList(newStudent2);
                Student s = studentList[5];
                Assert.Fail("Test should fail!");
            }
            catch (IndexOutOfRangeException ind)
            {
                Assert.IsTrue(ind is IndexOutOfRangeException);
            }
        }

        [TestMethod]
        public void TestStudentIdIndexer()
        {
            studentList.AddStudentToList(newStudent);
            studentList.AddStudentToList(newStudent2);
            Student s = studentList["X1111111"];
            Assert.AreEqual(s.StudentID, "X1111111");
            Assert.AreEqual(s.StudentName, "New Student");
            Assert.AreEqual(s.StudentGender, Gender.Female);
        }

        [TestMethod]
        public void TestStudentIdIndexerWithException()
        {
            try
            {
                studentList.AddStudentToList(newStudent);
                studentList.AddStudentToList(newStudent2);
                Student s = studentList["X"];
                Assert.Fail("Test should fail!");
            }
            catch (IndexOutOfRangeException ind)
            {
                Assert.IsTrue(ind is IndexOutOfRangeException);
            }
        }
    }
}
