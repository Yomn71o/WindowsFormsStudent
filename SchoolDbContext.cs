using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsStudent;
namespace WindowsFormsStudent
{
    public class SchoolDbContext
    {
        private List<Student> _students;
        public SchoolDbContext()
        {
            _students = new List<Student>();
        }
        public List<Student> GetAllStudent()
        {
            return _students;
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public void UpdateStudent(Student updatedStudent)
        {
            var student = _students.FirstOrDefault(s => s.Id == updatedStudent.Id);

            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Class = updatedStudent.Class;
                student.Age = updatedStudent.Age;

                if (updatedStudent.ImageData != null)
                {
                    student.ImageData = updatedStudent.ImageData;
                }
            }
        }
        public void DeleteStudent(int Id)
        {
            var student = _students.FirstOrDefault(s => s.Id == Id);

            if (student != null)
            {
                _students.Remove(student);
            }
        }
    }
}
 