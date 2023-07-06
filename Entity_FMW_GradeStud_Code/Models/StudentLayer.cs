using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FMW_LectureCode.Models
{
    internal class StudentLayer
    {
        public static readonly DemoData_Student db = new DemoData_Student();

        public List<Student> GetAll() { 
        return db.Students.ToList<Student>(); //immediate query fired
        }

        public void AddStudent(Student s1)
        {
            db.Add<Student>(s1);
            db.SaveChanges(); //this is where query is fired
        }

        public void DeleteStudent(int Id)
        {
            Student d=db.Find<Student>(Id);
            if(d!=null)
            {
            db.Remove<Student>(d);
            }
            db.SaveChanges() ;
        }

        public void UpdateStudent(Student s)
        {
            DemoData_Student db=new DemoData_Student(); //updation wasnt happening from same rfrnc we created which was working for all other cmds ie tracking so we need a rfrnc for updates independently
            {
                db.Entry(s).State=EntityState.Modified; //optional
                db.Update<Student>(s);  
            }
            db.SaveChanges();
        }
    }
}
