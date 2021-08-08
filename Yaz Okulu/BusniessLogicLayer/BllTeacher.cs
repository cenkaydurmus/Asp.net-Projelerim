using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusniessLogicLayer
{
   public class BllTeacher
    {
        DalTeacher dalTeacher = new DalTeacher();
        public List<EntityTeacher> BllListTeacher()
        {
            return dalTeacher.ListTeacher();
        }

        public void BllDeleteTeacher(int id)
        {
            dalTeacher.DeleteTeacher(id);
        }

        public void BllAddTeacher(EntityTeacher teacher)
        {
            dalTeacher.AddTeacher(teacher);
        }

        public List<EntityLesson> BllListLessons()
        {
            return dalTeacher.ListLessons();
        }

        public void BllEditTeacher(EntityTeacher teacher,int id)
        {
            dalTeacher.EditTeacher(teacher,id);
        }
    }
}
