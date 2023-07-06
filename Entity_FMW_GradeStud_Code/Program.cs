using Entity_FMW_LectureCode.Models;

namespace Entity_FMW_LectureCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentLayer studentLayer = new StudentLayer();
            List<Student> s1 = studentLayer.GetAll();
            s1.ForEach(item =>
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}" + $"{item.Height}{item.Weight}{item.GradeId}");
            });

            Student stud1 = new Student()
            {
                //StudentId = 9, //primary key can not be entered explicitly cz auto incremented
                FirstName = "Sensei",
                LastName = "Jadhav",
                Height = 6,
                Weight = 68,
                GradeId = null
            };

            studentLayer.AddStudent( stud1 );
    /*        int id = 7;
            studentLayer.DeleteStudent(id);*/
 /*           int sid = 5;
            Student stud2 = new Student()
            {
                StudentId = sid, //compulsory to assign the position as id where this obj has to be replaced as a record even tho primary auto inc cannot b assigned explicitly
                FirstName = "Ganu",
                LastName = "Gandu",
                Height = 5,
                Weight = 120,
                GradeId = 3
            };
            //studentLayer.AddStudent(stud2);


            studentLayer.UpdateStudent( stud2 );*/
        }
    }
}